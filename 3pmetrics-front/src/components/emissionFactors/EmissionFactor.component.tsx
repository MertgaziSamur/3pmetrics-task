import { Box } from "@mui/material";
import { DataGrid } from "@mui/x-data-grid";
import { GridColDef } from "@mui/x-data-grid/models";
import moment from "moment";
import React from "react";
import { IEmissionFactor } from "../../types/global.typing";
import "./emissionFactors-grid.scss";

const column: GridColDef[] = [
  { field: "Id", headerName: "Id", width: 100 },
  { field: "CatalogId", headerName: "CatalogId", width: 200 },
  { field: "EmissionFactorTitle", headerName: "EmissionFactorTitle", width: 150 },
  { field: "EmissionFactorValue", headerName: "EmissionFactorValue", width: 150 },
  { field: "EffectiveStartDate", headerName: "EffectiveStartDate", width: 150 },
  { field: "EffectiveEndDate", headerName: "EffectiveEndDate", width: 150 },
  { field: "CreationDate", headerName: "CreationDate", width: 150, 
      renderCell: (params) => moment(params.row.CreationDate).fromNow()},
  
];

interface IEmissionFactorsGridProps {
    data: IEmissionFactor[]
}

const EmissionFactorsGrid = ({ data } :IEmissionFactorsGridProps ) => {
  return (
    <Box sx = {{width:"100%", height:450}} className="emissionFactors-grid">
      <DataGrid rows={data} columns={column} getRowId={(row) => row.Id} rowHeight={50} />
    </Box>
  );
};

export default EmissionFactorsGrid;
