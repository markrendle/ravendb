﻿//-----------------------------------------------------------------------
// <copyright file="ColumnInfo.cs" company="Microsoft Corporation">
//     Copyright (c) Microsoft Corporation.
// </copyright>
//-----------------------------------------------------------------------

namespace Microsoft.Isam.Esent.Interop
{
    /// <summary>
    /// Information about one esent column. This is not an interop
    /// class, but is used by the meta-data helper methods.
    /// </summary>
    public class ColumnInfo
    {
        /// <summary>
        /// Initializes a new instance of the ColumnInfo class.
        /// </summary>
        /// <param name="name">Name of the column.</param>
        /// <param name="columnid">ID of the column.</param>
        /// <param name="coltyp">Type of the column.</param>
        /// <param name="cp">Codepage of the column.</param>
        /// <param name="maxLength">Maximum length of the column.</param>
        /// <param name="defaultValue">Column default value.</param>
        /// <param name="grbit">Column option.</param>
        internal ColumnInfo(
            string name,
            JET_COLUMNID columnid,
            JET_coltyp coltyp,
            JET_CP cp,
            int maxLength,
            byte[] defaultValue,
            ColumndefGrbit grbit)
        {
            this.Name = name;
            this.Columnid = columnid;
            this.Coltyp = coltyp;
            this.Cp = cp;
            this.MaxLength = maxLength;
            this.DefaultValue = defaultValue;
            this.Grbit = grbit;
        }

        /// <summary>
        /// Gets the name of the column.
        /// </summary>
        public string Name { get; private set; }

        /// <summary>
        /// Gets the ID of the column.
        /// </summary>
        public JET_COLUMNID Columnid { get; private set; }

        /// <summary>
        /// Gets the type of the column.
        /// </summary>
        public JET_coltyp Coltyp { get; private set; }

        /// <summary>
        /// Gets the code page of the column.
        /// </summary>
        public JET_CP Cp { get; private set; }

        /// <summary>
        /// Gets the maximum length of the column.
        /// </summary>
        public int MaxLength { get; private set; }

        /// <summary>
        /// Gets the default value of the column.
        /// </summary>
        public byte[] DefaultValue { get; private set; }

        /// <summary>
        /// Gets the column options.
        /// </summary>
        public ColumndefGrbit Grbit { get; private set; }
    }
}