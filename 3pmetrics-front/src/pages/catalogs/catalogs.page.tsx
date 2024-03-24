import { useEffect, useState } from "react";
import "./catalogs.scss";
import httpModule from "../../helpers/http.module";
import { ICatalog } from "../../types/global.typing";
import { Button, CircularProgress } from "@mui/material";
import { useNavigate } from "react-router-dom";
import { Add } from "@mui/icons-material";
import CatalogsGrid from "../../components/catalogs/CatalogsGrid.component";

const Catalogs = () => {
  const [catalogs, setCatalogs] = useState<ICatalog[]>([]);
  const [loading, setLoading] = useState<boolean>(false);
  const redirect = useNavigate();
  useEffect(() => {
    setLoading(true);
    httpModule
      .get<ICatalog[]>("/catalogs")
      .then((response) => {
        setCatalogs(response.data);
        setLoading(false);
      })
      .catch((error) => {
        alert("Error");
        console.log(error);
        setLoading(false);
      });
  }, []);

  console.log(catalogs);

  return (
    <div className="content catalogs">
      <div className="heading">
        <h2>Catalogs</h2>
        <Button variant="outlined" onClick={() => redirect("/catalogs/add")}>
          <Add />
        </Button>
      </div>

      {loading ? (
        <CircularProgress size={100} />
      ) : catalogs.length === 0 ? (
        <h1>No Catalog</h1>
      ) : (
        <CatalogsGrid data={catalogs} />
      )}
    </div>
  );
};

export default Catalogs;
