import { Box } from "@mui/material";
import { DataGrid } from "@mui/x-data-grid";
import { GridColDef } from "@mui/x-data-grid/models";
import moment from "moment";
import React from "react";
import { ICatalog } from "../../types/global.typing";
import "./catalogs-grid.scss";

const column: GridColDef[] = [
  { field: "Id", headerName: "Id", width: 100 },
  { field: "CreatorId", headerName: "CreatorId", width: 200 },
  { field: "CatalogName", headerName: "CatalogName", width: 150 },
  {
    field: "creationDate",
    headerName: "Creation Time",
    width: 200,
    renderCell: (params) =>
      moment(params.row.creationDate).format("YYYY-MM-DD"),
  },
];

interface ICatalogsGridProps {
    data: ICatalog[]
}

const CatalogsGrid = ({ data } :ICatalogsGridProps ) => {
  return (
    <Box sx = {{width:"100%", height:450}} className="catalogs-grid">
      <DataGrid rows={data} columns={column} getRowId={(row) => row.Id} rowHeight={50} />
    </Box>
  );
};

export default CatalogsGrid;
