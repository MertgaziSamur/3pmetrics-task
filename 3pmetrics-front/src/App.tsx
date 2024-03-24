import { useContext, lazy, Suspense } from "react";
import { ThemeContext } from "./context/theme.context";
import Navbar from "./components/navbar/navbar.component";
import { Routes, Route } from "react-router-dom";
import CustomLinearProgress from "./components/custom-linear-progress/CustomLinearProgress.component";

const Home = lazy(() => import("./pages/home/home.page"));

const Catalogs = lazy(() => import("./pages/catalogs/catalogs.page"));
const AddCatalog = lazy(() => import("./pages/catalogs/AddCatalog.page"));

const EmissionFactors = lazy(() => import("./pages/emissinFactors/emissionFactors.page"));
const AddEmissionFactor = lazy(() => import("./pages/emissinFactors/AddEmissionFactor.page"));

const EmissionPoints = lazy(() => import("./pages/emissionPoints/emissionPoints.page"));
const AddEmissionPoint = lazy(() => import("./pages/emissionPoints/AddEmissionPoint.page"));

const EmissionSources = lazy(() => import("./pages/emissionSources/emissionSources.page"));
const AddEmissionSource = lazy(() => import("./pages/emissionSources/AddEmissionSource.page"));

const EmissionSourcesUnits = lazy(() => import("./pages/emissionSourcesUnits/emissionSourcesUnits.page"));
const AddEmissionSourcesUnit = lazy(() => import("./pages/emissionSourcesUnits/AddEmissionSource.page"));
const App = () => {
  const { darkMode } = useContext(ThemeContext);

  const appStyles = darkMode ? "app dark" : "app";

  return (
    <div className={appStyles}>
      <Navbar />
      <div className="wrapper">
        <Suspense fallback={<CustomLinearProgress />}>
          <Routes>
            <Route path="/" element={<Home />} />
            <Route path="/catalogs">
              <Route index element={<Catalogs />} />
              <Route path = "add" element= {<AddCatalog/>} />
            </Route>
            <Route path="/emissionFactors">
              <Route index element={<EmissionFactors />} />
              <Route path = "add" element = {<AddEmissionFactor/>}/>
            </Route>
            <Route path="/emissionPoints">
              <Route index element={<EmissionPoints />} />
              <Route path = "add" element = {<AddEmissionPoint/>}/>
            </Route>
            <Route path="/emissionSources">
              <Route index element={<EmissionSources />} />
              <Route path = "add" element = {<AddEmissionSource/>}/>
            </Route>
            <Route path="/emissionSourcesUnits">
              <Route index element={<EmissionSourcesUnits />} />
              <Route path = "add" element = {<AddEmissionSourcesUnit/>}/>
            </Route>
          </Routes>
        </Suspense>
      </div>
    </div>
  );
};

export default App;
