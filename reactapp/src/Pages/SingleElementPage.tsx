type MaybeNumber = number | null;
type MaybeString = string | null;

export class Element {
	atomicNumber: number;
	elementName: string;
	symbol: string;
	atomicWeight: number;
	period: number;
	group: number;
	ionicRadius: MaybeNumber;
	atomicRadius: MaybeNumber;
	electronegativity: MaybeNumber;
	firstIonizationPotential: MaybeNumber;
	density: MaybeNumber;
	meltingPoint: MaybeNumber;
	boilingPoint: MaybeNumber;
	isotopes: MaybeNumber;
	specificHeatCapacity: MaybeNumber;
	electronConfiguration: MaybeString;
	displayRow: number;
	displayColumn: number;

	constructor(atomicNumber: number, elementName: string, symbol: string, atomicWeight: number,
		period: number, group: number, ionicRadius: MaybeNumber, atomicRadius: MaybeNumber,
		electronegativity: MaybeNumber, firstIonizationPotential: MaybeNumber, density: MaybeNumber,
		meltingPoint: MaybeNumber, boilingPoint: MaybeNumber, isotopes: MaybeNumber, specificHeatCapacity: MaybeNumber,
		electronConfiguration: MaybeString, displayRow: number, displayColumn: number)
	{
		this.atomicNumber = atomicNumber;
		this.elementName = elementName;
		this.symbol = symbol;
		this.atomicWeight = atomicWeight;
		this.period = period;
		this.group = group;
		this.ionicRadius = ionicRadius;
		this.atomicRadius = atomicRadius;
		this.electronegativity = electronegativity;
		this.firstIonizationPotential = firstIonizationPotential;
		this.density = density;
		this.meltingPoint = meltingPoint;
		this.boilingPoint = boilingPoint;
		this.isotopes = isotopes;
		this.specificHeatCapacity = specificHeatCapacity;
		this.electronConfiguration = electronConfiguration;
		this.displayRow = displayRow;
		this.displayColumn = displayColumn;
	}
}