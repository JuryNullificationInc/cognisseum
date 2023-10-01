import React = require("react");
import Box from '@mui/material/Box';
import Card from '@mui/material/Card';
import CardActions from '@mui/material/CardActions';
import CardContent from '@mui/material/CardContent';
import Typography from '@mui/material/Typography';

export interface ElementTypeProps {
	imagePath: string;
	color: string;
	name: string;
	acronym: string;

/*	constructor(imagePath: string, color: string, name: string, acronym: string) {
		this.imagePath = imagePath;
		this.color = color;
		this.name = name;
		this.acronym = acronym;
	}*/
}

export default function ElementTypePill({ imagePath, color, name, acronym }: ElementTypeProps)
{
	return (
		<Card sx={{ bgcolor: { color }, }}>
			<Box>
				<img src={imagePath} />
			</Box>
			<Box>
				<p>{name}</p>
			</Box>
		</Card>
	);
}
