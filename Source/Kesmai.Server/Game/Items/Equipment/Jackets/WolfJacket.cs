using System.Collections.Generic;
using System.IO;
using Kesmai.Server.Network;

namespace Kesmai.Server.Items;

public partial class WolfJacket : Jacket
{
	/// <inheritdoc />
	public override uint BasePrice => 20;

	/// <inheritdoc />
	public override int Weight => 1300;

	/// <inheritdoc />
	public override int Hindrance => 1;

	/// <summary>
	/// Initializes a new instance of the <see cref="WolfJacket"/> class.
	/// </summary>
	public WolfJacket() : base(259)
	{
	}

	public override void GetDescription(List<LocalizationEntry> entries)
	{
		entries.Add(new LocalizationEntry(6200000, 6200177)); /* [You are looking at] [a jacket made from the fur of a wolf.] */

		if (Identified)
			entries.Add(new LocalizationEntry(6250099)); /* The jacket appears quite ordinary. */
	}
}