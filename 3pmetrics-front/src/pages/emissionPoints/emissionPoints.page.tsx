import { useEffect, useState } from "react";
import "./emissionPoints.scss";
import httpModule from "../../helpers/http.module";
import {  IEmissionPoint } from "../../types/global.typing";
import { Button, CircularProgress } from "@mui/material";
import { useNavigate } from "react-router-dom";
import { Add } from "@mui/icons-material";
import EmissionPointsGrid from "../../components/emissionPoints/EmissionPointsGrid.component";
//import CatalogsGrid from "../../components/catalogs/CatalogsGrid.component";

const EmissionPoints = () => {
  const [emissionPoints, setEmissionPoints] = useState<IEmissionPoint[]>([]);
  const [loading, setLoading] = useState<boolean>(false);
  const redirect = useNavigate();
  useEffect(() => {
    setLoading(true);
    httpModule
      .get<IEmissionPoint[]>("/emissionPoints")
      .then((response) => {
        setEmissionPoints(response.data);
        setLoading(false);
      })
      .catch((error) => {
        alert("Error");
        console.log(error);
        setLoading(false);
      });
  }, []);

  return (
    <div className="content emissionPoints">
      <div className="heading">
        <h2>Emission Points</h2>
        <Button
          variant="outlined"
          onClick={() => redirect("/emissionPoints/add")}
        >
          <Add />
        </Button>
      </div>

      {loading ? (
        <CircularProgress size={100} />
      ) : emissionPoints.length === 0 ? (
        <h1>No Emission Point</h1>
      ) : (
        <EmissionPointsGrid data={emissionPoints} />
      )}
    </div>
  );
};

export default EmissionPoints;
