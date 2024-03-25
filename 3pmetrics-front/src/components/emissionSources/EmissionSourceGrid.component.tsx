import { Box } from "@mui/material";
import { DataGrid } from "@mui/x-data-grid";
import { GridColDef } from "@mui/x-data-grid/models";
import moment from "moment";
import { IEmissionSource } from "../../types/global.typing";
import "./emissionSources-grid.scss";

const column: GridColDef[] = [
  { field: "Id", headerName: "Id", width: 100 },
  { field: "CreatorId", headerName: "CreatorId", width: 100 },
  { field: "SourceName", headerName: "SourceName", width: 150 },
  { field: "SourceIcon", headerName: "SourceIcon", width: 150 },
  {
    field: "creationDate",
    headerName: "Creation Time",
    width: 200,
    renderCell: (params) =>
      moment(params.row.creationDate).format("YYYY-MM-DD"),
  },
];

interface IEmissionSourcesGridProps {
    data: IEmissionSource[]
}

const EmissionSourcesGrid = ({ data } :IEmissionSourcesGridProps ) => {
  return (
    <Box sx = {{width:"100%", height:450}} className="emissionSources-grid">
      <DataGrid rows={data} columns={column} getRowId={(row) => row.Id} rowHeight={50} />
    </Box>
  );
};

export default EmissionSourcesGrid;
