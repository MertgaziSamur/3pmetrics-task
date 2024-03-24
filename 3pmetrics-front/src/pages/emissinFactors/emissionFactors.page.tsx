import { useEffect, useState } from "react";
import "./emissionFactors.scss";
import httpModule from "../../helpers/http.module";
import { IEmissionFactor } from "../../types/global.typing";
import { Button, CircularProgress } from "@mui/material";
import { useNavigate } from "react-router-dom";
import { Add } from "@mui/icons-material";
import EmissionFactorsGrid from "../../components/emissionFactors/EmissionFactor.component";
//import CatalogsGrid from "../../components/catalogs/CatalogsGrid.component";

const EmissionFactors = () => {
  const [emissionFactors, setEmissionFactors] = useState<IEmissionFactor[]>([]);
  const [loading, setLoading] = useState<boolean>(false);
  const redirect = useNavigate();
  useEffect(() => {
    setLoading(true);
    httpModule
      .get<IEmissionFactor[]>("/emissionFactors")
      .then((response) => {
        setEmissionFactors(response.data);
        setLoading(false);
      })
      .catch((error) => {
        alert("Error");
        console.log(error);
        setLoading(false);
      });
  }, []);

  return (
    <div className="content emissionFactors">
      <div className="heading">
        <h2>Emission Factors</h2>
        <Button
          variant="outlined"
          onClick={() => redirect("/emissionFactors/add")}
        >
          <Add />
        </Button>
      </div>

      {loading ? (
        <CircularProgress size={100} />
      ) : emissionFactors.length === 0 ? (
        <h1>No Emission Factor</h1>
      ) : (
        <EmissionFactorsGrid data={emissionFactors} />
      )}
    </div>
  );
};

export default EmissionFactors;
