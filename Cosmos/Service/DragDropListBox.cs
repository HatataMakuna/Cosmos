using System;
using System.Drawing;
using System.Windows.Forms;

namespace Cosmos.Service
{
    public class DragDropListBox : ListBox
    {
        private int dragIndex;
        private Rectangle dragBoxFromMouseDown;

        public DragDropListBox()
        {
            this.AllowDrop = true;
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);

            // Get the index of the item the mouse is below
            dragIndex = this.IndexFromPoint(e.X, e.Y);
            if (dragIndex != -1)
            {
                // Remember the point where the mouse down occurred
                dragBoxFromMouseDown = new Rectangle(
                    e.X - SystemInformation.DragSize.Width / 2,
                    e.Y - SystemInformation.DragSize.Height / 2,
                    SystemInformation.DragSize.Width,
                    SystemInformation.DragSize.Height);
            }
            else
            {
                dragBoxFromMouseDown = Rectangle.Empty;
            }
        }

        protected override void OnMouseMove(MouseEventArgs e)
        {
            base.OnMouseMove(e);

            if (e.Button == MouseButtons.Left && dragIndex != -1)
            {
                // If the mouse moves outside the rectangle, start the drag
                if (!dragBoxFromMouseDown.Contains(e.X, e.Y))
                {
                    // Initiate dragging with the item's text
                    this.DoDragDrop(this.Items[dragIndex], DragDropEffects.Move);
                }
            }
        }

        protected override void OnDragOver(DragEventArgs e)
        {
            base.OnDragOver(e);

            // Provide visual feedback about the potential drop location
            e.Effect = e.AllowedEffect;

            // Get the index of the item the mouse is below
            int indexOfItemUnderMouseToDrop = this.IndexFromPoint(this.PointToClient(new Point(e.X, e.Y)));

            // If the mouse is above an item (not below all items), then
            if (indexOfItemUnderMouseToDrop != -1)
            {
                // Create a graphics object from the list box
                using (Graphics g = this.CreateGraphics())
                {
                    // Draw a horizontal line between the items
                    Rectangle itemRect = this.GetItemRectangle(indexOfItemUnderMouseToDrop);
                    g.DrawLine(Pens.Black,
                        itemRect.Left, itemRect.Top,
                        itemRect.Right, itemRect.Top);
                }
            }
        }

        protected override void OnDragDrop(DragEventArgs e)
        {
            base.OnDragDrop(e);

            // Get the index where to drop the item
            Point point = this.PointToClient(new Point(e.X, e.Y));
            int indexOfItemUnderMouseToDrop = this.IndexFromPoint(point);

            if (indexOfItemUnderMouseToDrop == -1)
                indexOfItemUnderMouseToDrop = this.Items.Count - 1;

            // Get the object being dragged
            string draggedItem = (string)e.Data.GetData(typeof(string));

            // If we're dragging and dropping within the same list box
            if (this.Items.Contains(draggedItem))
            {
                // If the drag index is different from the drop index
                if (dragIndex != indexOfItemUnderMouseToDrop)
                {
                    // Remove the item from its original position
                    this.Items.RemoveAt(dragIndex);

                    // Insert the item at its new position
                    if (indexOfItemUnderMouseToDrop > dragIndex)
                        indexOfItemUnderMouseToDrop--;

                    this.Items.Insert(indexOfItemUnderMouseToDrop, draggedItem);

                    // Raise an event to notify that reordering has occurred
                    OnItemsReordered(dragIndex, indexOfItemUnderMouseToDrop);
                }
            }
            this.Refresh();
        }

        // Custom event to notify when items are reordered
        public event EventHandler<ReorderEventArgs> ItemsReordered;

        protected virtual void OnItemsReordered(int oldIndex, int newIndex)
        {
            ItemsReordered?.Invoke(this, new ReorderEventArgs(oldIndex, newIndex));
        }
    }

    // Event arguments for the reordering event
    public class ReorderEventArgs : EventArgs
    {
        public int OldIndex { get; }
        public int NewIndex { get; }

        public ReorderEventArgs(int oldIndex, int newIndex)
        {
            OldIndex = oldIndex;
            NewIndex = newIndex;
        }
    }
}
