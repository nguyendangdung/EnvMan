//------------------------------------------------------------------------
// <copyright file="DgvBrowseFolderCommand.cs" company="SETCHIN Freelance Consulting">
// Copyright (C) 2006-2011 SETCHIN Freelance Consulting
// </copyright>
// <author>
// Vlad Setchin
// </author>
//------------------------------------------------------------------------

// EnvMan - The Open-Source Windows Environment Variables Manager
// Copyright (C) 2006-2011 SETCHIN Freelance Consulting 
// <http://www.setchinfc.com.au>
// EnvMan Development Group: <mailto:envman-dev@googlegroups.com>
//  
// This program is free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License as published by
// the Free Software Foundation, either version 3 of the License, or
// (at your option) any later version.
//
// This program is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU General Public License for more details.
//
// You should have received a copy of the GNU General Public License
// along with this program.  If not, see <http://www.gnu.org/licenses/>.

namespace EnvManager.Handlers
{
    using System.Windows.Forms;

    /// <summary>
    /// Browse Folder Data Grid View Command
    /// </summary>
    public class DgvBrowseFolderCommand : DgvModifyValueCommand
    {
        /// <summary>
        /// Data Grid View Command Name
        /// </summary>
        private const string DgvCommandName = "Browse Folder";

        /// <summary>
        /// Initializes a new instance of the <see cref="DgvBrowseFolderCommand"/> class.
        /// </summary>
        /// <param name="dgvHandler">The DGV handler.</param>
        public DgvBrowseFolderCommand(DgvHandler dgvHandler)
            : base(dgvHandler, DgvCommandName)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DgvBrowseFolderCommand"/> class.
        /// </summary>
        /// <param name="dgvHandler">The DGV handler.</param>
        /// <param name="row">The Data Grid View row.</param>
        public DgvBrowseFolderCommand(DgvHandler dgvHandler, DataGridViewRow row)
            : base(dgvHandler, DgvCommandName)
        {
            this.CurrentRow = this.CloneRow(row);
            this.CurrentRowIndex = row.Index;
        }
    }
}
