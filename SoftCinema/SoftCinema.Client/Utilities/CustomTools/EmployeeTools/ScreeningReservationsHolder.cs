﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SoftCinema.Models;

namespace SoftCinema.Client.Utilities.CustomTools.EmployeeTools
{
    class ScreeningReservationsHolder : GroupBox
    {
        private List<Ticket> _reservedTickets { get; set; }

        public ScreeningReservationsHolder()
        {
            
        }

        public ScreeningReservationsHolder(Point startingPoint, Size size, List<Ticket> reservations)
        {
            this._reservedTickets = reservations;
            this.Location = startingPoint;
            this.Size = size;
            RenderReservationRows();
        }

        private void RenderReservationRows()
        {
            if (this._reservedTickets.Count == 0)
            {
                this.Controls.Clear();
                MessageBox.Show("No reservations");
                return;
            }

            this.Controls.Clear();

            var rowCoordinates = new Point(0, 0);

            foreach (var reservedTicket in _reservedTickets)
            {
                var row = new ReservationRow(rowCoordinates, reservedTicket);
                row.Location = rowCoordinates;
                this.Controls.Add(row);

                rowCoordinates.Y += row.Height;
            }
        }
    }
}