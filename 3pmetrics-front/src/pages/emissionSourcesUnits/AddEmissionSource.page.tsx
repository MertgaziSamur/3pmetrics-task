import { useState } from "react";
import "./emissionSourcesUnits.scss";
import { ICreateEmissionSourcesUnit } from "../../types/global.typing";
import { Button, TextField } from "@mui/material";
import { useNavigate } from "react-router-dom";
import httpModule from "../../helpers/http.module";


const AddEmissionSourcesUnit = () => {
  const [emissionSourcesUnit, setEmissionSourcesUnit] = useState<ICreateEmissionSourcesUnit>({
    CreatorId : "",
    UnitTitle : "",
    UnitSymbol : ""
  });
  const redirect = useNavigate();

  const handleClickSaveBtn = () => {
    if (emissionSourcesUnit.CreatorId ==="" || emissionSourcesUnit.UnitSymbol === "" || emissionSourcesUnit.UnitTitle === "") {
      alert("Fill all fields");
      return;
    }
    httpModule
      .post("/emissionSourcesUnits", emissionSourcesUnit)
      .then((response) => redirect("/emissionSourcesUnit"))    
      .catch((error) => console.log(error));
  };
  const handleClickBackBtn = () => {
    redirect("/emissionSourcesUnit");
  };


  return (
    <div className="content">
      <div className="add-emissionSource">
        <h2>Add New Emission Sources Unit</h2>
        <TextField
          autoComplete="off"
          label="Creator Id"
          variant="outlined"
          name="CreatorId"
          value={emissionSourcesUnit.CreatorId}
          onChange={(e) =>
            setEmissionSourcesUnit({ ...emissionSourcesUnit, CreatorId: e.target.value }
          )}
        />
        <TextField
          autoComplete="off"
          label="Unit Symbol"
          variant="outlined"
          name="UnitSymbol"
          value={emissionSourcesUnit.UnitSymbol}
          onChange={(e) =>
            setEmissionSourcesUnit({ ...emissionSourcesUnit, UnitSymbol: e.target.value }
          )}
        />
        <TextField
          autoComplete="off"
          label="Unit Title"
          variant="outlined"
          name="UnitTitle"
          value={emissionSourcesUnit.UnitTitle}
          onChange={(e) =>
            setEmissionSourcesUnit({ ...emissionSourcesUnit, UnitTitle: e.target.value }
          )}
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

export default AddEmissionSourcesUnit;