import { useState } from "react";
import "./emissionSources.scss";
import { IcreateEmissionSourceDto } from "../../types/global.typing";
import { Button, TextField } from "@mui/material";
import { useNavigate } from "react-router-dom";
import httpModule from "../../helpers/http.module";


const AddEmissionSource = () => {
  const [emissionSource, setEmissionSource] = useState<IcreateEmissionSourceDto>({
    CreatorId: "",
    SourceName: "",
    SourceIcon: "",
  });
  const redirect = useNavigate();

  const handleClickSaveBtn = () => {
    if (emissionSource.CreatorId ==="" || emissionSource.SourceIcon ==="" || emissionSource.SourceName) {
      alert("Fill all fields");
      return;
    }
    httpModule
      .post("/emissionSource", emissionSource)
      .then((response) => redirect("/emissionSource"))    
      .catch((error) => console.log(error));
  };
  const handleClickBackBtn = () => {
    redirect("/emissionSource");
  };


  return (
    <div className="content">
      <div className="add-emissionSource">
        <h2>Add New Emission Source</h2>
        <TextField
          autoComplete="off"
          label="Creator Id"
          variant="outlined"
          name="CreatorId"
          value={emissionSource.CreatorId}
          onChange={(e) =>
            setEmissionSource({ ...emissionSource, CreatorId: e.target.value }
          )}
        />
        <TextField
          autoComplete="off"
          label="Source Icon"
          variant="outlined"
          name="SourceIcon"
          value={emissionSource.SourceIcon}
          onChange={(e) =>
            setEmissionSource({ ...emissionSource, SourceIcon: e.target.value }
          )}
        />
        <TextField
          autoComplete="off"
          label="Source Name"
          variant="outlined"
          name="SourceName"
          value={emissionSource.SourceName}
          onChange={(e) =>
            setEmissionSource({ ...emissionSource, SourceName: e.target.value }
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

export default AddEmissionSource;