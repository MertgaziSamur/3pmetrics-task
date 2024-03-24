import { useEffect, useState } from "react";
import "./emissionSourcesUnits.scss";
import httpModule from "../../helpers/http.module";
import { IEmissionSourcesUnit } from "../../types/global.typing";
import { Button, CircularProgress } from "@mui/material";
import { useNavigate } from "react-router-dom";
import { Add } from "@mui/icons-material";
import EmissionSourcesUnitGrid from "../../components/emissionSourcesUnits/EmissionSourcesUnitsGrid.component";

const EmissionSourcesUnits = () => {
  const [emissionSourcesUnits, setEmissionSourcesUnits] = useState<IEmissionSourcesUnit[]>([]);
  const [loading, setLoading] = useState<boolean>(false);
  const redirect = useNavigate();
  useEffect(() => {
    setLoading(true);
    httpModule
      .get<IEmissionSourcesUnit[]>("/emissionSourcesUnits")
      .then((response) => {
        setEmissionSourcesUnits(response.data);
        setLoading(false);
      })
      .catch((error) => {
        alert("Error");
        console.log(error);
        setLoading(false);
      });
  }, []);

  return (
    <div className="content emissionSourcesUnits">
      <div className="heading">
        <h2>Emission Sources Units</h2>
        <Button
          variant="outlined"
          onClick={() => redirect("/emissionSourcesUnits/add")}
        >
          <Add />
        </Button>
      </div>

      {loading ? (
        <CircularProgress size={100} />
      ) : emissionSourcesUnits.length === 0 ? (
        <h1>No Emission Sources</h1>
      ) : (
        <EmissionSourcesUnitGrid data={emissionSourcesUnits} />
      )}
    </div>
  );
};

export default EmissionSourcesUnits;
