import { Box } from "@mui/material";
import { DataGrid } from "@mui/x-data-grid";
import { GridColDef } from "@mui/x-data-grid/models";
import moment from "moment";
import { IEmissionSourcesUnit } from "../../types/global.typing";
import "./emissionSourcesUnits-grid.scss";
const column: GridColDef[] = [
  { field: "Id", headerName: "Id", width: 100 },
  { field: "CreatorId", headerName: "CreatorId", width: 100 },
  { field: "UnitTitle", headerName: "UnitTitle", width: 150 },
  { field: "UnitSymbol", headerName: "UnitSymbol", width: 150 },
  {
    field: "CreationDate",
    headerName: "Creation Time",
    width: 200,
    renderCell: (params) =>
      moment(params.row.creationDate).format("YYYY-MM-DD"),
  },
];

interface IEmissionSourcesUnitGridProps {
    data: IEmissionSourcesUnit[]
}

const EmissionSourcesUnitGrid = ({ data } :IEmissionSourcesUnitGridProps ) => {
  return (
    <Box sx = {{width:"100%", height:450}} className="emissionSourcesUnits-grid">
      <DataGrid rows={data} columns={column} getRowId={(row) => row.Id} rowHeight={50} />
    </Box>
  );
};

export default EmissionSourcesUnitGrid;
