import { useEffect, useState } from "react";
import "./emissionSources.scss";
import httpModule from "../../helpers/http.module";
import {  IEmissionSource } from "../../types/global.typing";
import { Button, CircularProgress } from "@mui/material";
import { useNavigate } from "react-router-dom";
import { Add } from "@mui/icons-material";
import EmissionSourcesGrid from "../../components/emissionSources/EmissionSourceGrid.component";


const EmissionSources = () => {
  const [emissionSources, setEmissionSources] = useState<IEmissionSource[]>([]);
  const [loading, setLoading] = useState<boolean>(false);
  const redirect = useNavigate();
  useEffect(() => {
    setLoading(true);
    httpModule
      .get<IEmissionSource[]>("/emissionSources")
      .then((response) => {
        setEmissionSources(response.data);
        setLoading(false);
      })
      .catch((error) => {
        alert("Error");
        console.log(error);
        setLoading(false);
      });
  }, []);

  return (
    <div className="content emissionSources">
      <div className="heading">
        <h2>Emission Sources</h2>
        <Button
          variant="outlined"
          onClick={() => redirect("/emissionSources/add")}
        >
          <Add />
        </Button>
      </div>

      {loading ? (
        <CircularProgress size={100} />
      ) : emissionSources.length === 0 ? (
        <h1>No Emission Sources</h1>
      ) : (
        <EmissionSourcesGrid data={emissionSources} />
      )}
    </div>
  );
};

export default EmissionSources;
