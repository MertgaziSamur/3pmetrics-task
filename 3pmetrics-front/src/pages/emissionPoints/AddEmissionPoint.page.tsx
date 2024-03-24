import { useState } from "react";
import "./emissionPoints.scss";
import { ICreateEmissionPointDto } from "../../types/global.typing";
import { Button, TextField } from "@mui/material";
import { useNavigate } from "react-router-dom";
import httpModule from "../../helpers/http.module";


const AddEmissionPoint = () => {
  const [emissionPoint, setEmissionPoint] = useState<ICreateEmissionPointDto>({
    CreatorId: "",
    EmissionSourceUnitId : "",
    PointDescription :"",
    PointIcon :"",
    PointName : "",
  });
  const redirect = useNavigate();

  const handleClickSaveBtn = () => {
    if (emissionPoint.CreatorId === "" || emissionPoint.EmissionSourceUnitId === "" || emissionPoint.PointDescription === "" || emissionPoint.PointIcon === "" || emissionPoint.PointName === ""  ) {
      alert("Fill all fields");
      return;
    }
    httpModule
      .post("/emissionPoint", emissionPoint)
      .then((response) => redirect("/emissionPoints"))    
      .catch((error) => console.log(error));
  };
  const handleClickBackBtn = () => {
    redirect("/emissionPoints");
  };


  return (
    <div className="content">
      <div className="add-emissionFactor">
        <h2>Add New Emission Factor</h2>
        <TextField
          autoComplete="off"
          label="Emission Sources Unit Id"
          variant="outlined"
          name="EmissionSourceUnitId"
          value={emissionPoint.EmissionSourceUnitId}
          onChange={(e) =>
            setEmissionPoint({ ...emissionPoint, EmissionSourceUnitId: e.target.value }
          )}
        />
        <TextField
          autoComplete="off"
          label="Creator Id"
          variant="outlined"
          name="CreatorId"
          value={emissionPoint.CreatorId}
          onChange={(e) =>
            setEmissionPoint({ ...emissionPoint, CreatorId: e.target.value }
          )}
        />
        <TextField
          autoComplete="off"
          label="Point Name"
          variant="outlined"
          name="PointName"
          value={emissionPoint.PointName}
          onChange={(e) =>
            setEmissionPoint({ ...emissionPoint, PointName: e.target.value }
          )}
        />
        <TextField
          autoComplete="off"
          label="Point Description"
          variant="outlined"
          name="PointDescription"
          value={emissionPoint.PointDescription} 
          onChange={(e) =>
            setEmissionPoint({ ...emissionPoint, PointDescription: e.target.value })
          }
        />
        <TextField
          autoComplete="off"
          label="Point Icon"
          variant="outlined"
          name="PointIcon"
          value={emissionPoint.PointIcon} 
          onChange={(e) =>
            setEmissionPoint({ ...emissionPoint, PointIcon: e.target.value })
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

export default AddEmissionPoint;