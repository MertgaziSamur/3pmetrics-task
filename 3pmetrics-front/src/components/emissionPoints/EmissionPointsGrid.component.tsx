import { Box } from "@mui/material";
import { DataGrid } from "@mui/x-data-grid";
import { GridColDef } from "@mui/x-data-grid/models";
import moment from "moment";
import React from "react";
import { IEmissionPoint } from "../../types/global.typing";

const column: GridColDef[] = [
  { field: "Id", headerName: "Id", width: 100 },
  { field: "EmissionSourceUnitId", headerName: "EmissionSourceUnitId", width: 200 },
  { field: "CreatorId", headerName: "CreatorId", width: 150 },
  { field: "PointName", headerName: "PointName", width: 150 },
  { field: "PointDescription", headerName: "PointDescription", width: 150 },
  { field: "PointIcon", headerName: "PointIcon", width: 150 },
  {
    field: "creationDate",
    headerName: "Creation Time",
    width: 200,
    renderCell: (params) =>
      moment(params.row.creationDate).format("YYYY-MM-DD"),
  },
];

interface IEmissionPointssGridProps {
    data: IEmissionPoint[]
}

const EmissionPointsGrid = ({ data } :IEmissionPointssGridProps ) => {
  return (
    <Box sx = {{width:"100%", height:450}} className="emissionPoints-grid">
      <DataGrid rows={data} columns={column} getRowId={(row) => row.Id} rowHeight={50} />
    </Box>
  );
};

export default EmissionPointsGrid;
