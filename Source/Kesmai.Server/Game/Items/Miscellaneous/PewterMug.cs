﻿using System;
using System.Collections.Generic;
using System.IO;
using Kesmai.Server.Game;
using Kesmai.Server.Network;

namespace Kesmai.Server.Items
{
	public partial class PewterMug : ItemEntity, ITreasure
	{
		/// <inheritdoc />
		public override int LabelNumber => 6000064;

		/// <inheritdoc />
		public override uint BasePrice => 700;

		/// <inheritdoc />
		public override int Weight => 15;

		/// <inheritdoc />
		public override int Category => 3;

		/// <summary>
		/// Initializes a new instance of the <see cref="PewterMug"/> class.
		/// </summary>
		public PewterMug() : base(283)
		{
		}

		/// <inheritdoc />
		public override void GetDescription(List<LocalizationEntry> entries)
		{
			entries.Add(new LocalizationEntry(6200000, 6200115)); /* [You are looking at] [a pewter mug.] */
		}
	}
}