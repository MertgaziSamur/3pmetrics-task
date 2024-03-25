import { useState } from "react";
import "./emissionFactors.scss";
import { ICreateEmissionFactorDto } from "../../types/global.typing";
import { Button, TextField } from "@mui/material";
import { useNavigate } from "react-router-dom";
import httpModule from "../../helpers/http.module";


const AddEmissionFactor = () => {
  const [emissionFactor, setEmissionFactor] = useState<ICreateEmissionFactorDto>({
    CreatorId: "",
    CatalogId: "",
    EmissionFactorTitle: "",
    EmissionFactorValue: "",
  });
  const redirect = useNavigate();

  const handleClickSaveBtn = () => {
    if (emissionFactor.CatalogId === "" || emissionFactor.CreatorId === "" || emissionFactor.EmissionFactorTitle === "" || emissionFactor.EmissionFactorValue === "") {
      alert("Fill all fields");
      return;
    }
    httpModule
      .post("/emissionFactors", emissionFactor)
      .then((response) => redirect("/emissionFactors"))    
      .catch((error) => console.log(error));
  };
  const handleClickBackBtn = () => {
    redirect("/emissionFactors");
  };

  return (
    <div className="content">
      <div className="add-emissionFactor">
        <h2>Add New Emission Factor</h2>
        <TextField
          autoComplete="off"
          label="Catalog Id"
          variant="outlined"
          name="CatalogId"
          value={emissionFactor.CatalogId}
          onChange={(e) =>
            setEmissionFactor({ ...emissionFactor, CatalogId: e.target.value })
          }
        />
        <TextField
          autoComplete="off"
          label="Creator Id"
          variant="outlined"
          name="CreatorId"
          value={emissionFactor.CreatorId} 
          onChange={(e) =>
            setEmissionFactor({ ...emissionFactor, CreatorId: e.target.value })
          }
        />
        <TextField
          autoComplete="off"
          label="Emission Factor Title"
          variant="outlined"
          name="EmissionFactorTitle"
          value={emissionFactor.EmissionFactorTitle} 
          onChange={(e) =>
            setEmissionFactor({ ...emissionFactor, EmissionFactorTitle: e.target.value })
          }
        />
        <TextField
          autoComplete="off"
          label="Emission Factor Value"
          variant="outlined"
          name="EmissionFactorValue"
          value={emissionFactor.EmissionFactorValue} 
          onChange={(e) =>
            setEmissionFactor({ ...emissionFactor, EmissionFactorValue: e.target.value })
          }
        />
        <br />
        <div className="btns">
          <Button
            variant="outlined"
            color="primary"
            onClick={handleClickSaveBtn}
          >
            Save
          </Button>
          <Button
            variant="outlined"
            color="secondary"
            onClick={handleClickBackBtn}
          >
            Back
          </Button>
        </div>
      </div>
    </div>
  );
};

export default AddEmissionFactor;