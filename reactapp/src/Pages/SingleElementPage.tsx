import { Component } from "react";
import { ElementTypeProps } from "../components/elementTypePill";

type MaybeNumber = number | null;
type MaybeString = string | null;

export interface NameAcronymWithImageProps {
	name: string;
	acronym: string;
	imagePath: string;
}

export interface ElementProps {
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
	classifications: ElementTypeProps[];
	phase: NameAcronymWithImageProps;
	crystalConfig: NameAcronymWithImageProps;
}

export default class App extends Component {
	static displayName = App.name;

	constructor(props: ElementProps) {
		super(props);
		this.state = {

		}
	}

	async populateElementData() {
		const response = await fetch('https://localhost:7004/api/element/element-by-atomic-number')
	}
}