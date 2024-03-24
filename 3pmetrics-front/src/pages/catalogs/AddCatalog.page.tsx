import { useState } from "react";
import "./catalogs.scss";
import { ICreateCatalogDto } from "../../types/global.typing";
import { Button, TextField } from "@mui/material";
import { useNavigate } from "react-router-dom";
import httpModule from "../../helpers/http.module";


const AddCatalog = () => {
  const [catalog, setCatalog] = useState<ICreateCatalogDto>({
    CreatorId: "",
    CatalogName: "",
  });
  const redirect = useNavigate();

  const handleClickSaveBtn = () => {
    if (catalog.CatalogName === "" || catalog.CreatorId === "") {
      alert("Fill all fields");
      return;
    }
    httpModule
      .post("/catalogs", catalog)
      .then((response) => redirect("/catalogs"))    
      .catch((error) => console.log(error));
  };
  const handleClickBackBtn = () => {
    redirect("/catalogs");
  };

  return (
    <div className="content">
      <div className="add-catalog">
        <h2>Add New Catalog</h2>
        <TextField
          autoComplete="off"
          label="Catalog Name"
          variant="outlined"
          name="CatalogName"
          value={catalog.CatalogName}
          onChange={(e) =>
            setCatalog({ ...catalog, CatalogName: e.target.value })
          }
        />
        <TextField
          autoComplete="off"
          label="Creator Id"
          variant="outlined"
          name="CreatorId"
          value={catalog.CreatorId} 
          onChange={(e) =>
            setCatalog({ ...catalog, CreatorId: e.target.value })
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

export default AddCatalog;
