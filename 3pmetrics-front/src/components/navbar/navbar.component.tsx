import { Link } from 'react-router-dom'
import './navbar.scss'
import {Menu, LightMode, DarkMode} from "@mui/icons-material"
import { ToggleButton } from '@mui/material'
import { useContext } from 'react'
import { ThemeContext } from '../../context/theme.context'

const links = [
    {href: "/", label: "Home"},
    {href: "/emissionFactors", label: "EmisionFactors"},
    {href: "/catalogs", label: "Catalogs"},
    {href: "/emissionPoints", label: "EmissionPoints"},
    {href: "/emissionSources", label: "EmissionSources"},
    {href: "/emissionSourcesUnits", label: "EmissionSourcesUnits"}

]


const Navbar = () => {
    const {darkMode, toggleDarkMode} = useContext(ThemeContext);
    return(
        <div className='navbar'>
            <div className="brand">
                <span>3pMetrics</span>
            </div>
            <div className="menu">
                <ul>
                    {links.map(item => (
                        <li key = {item.href}>
                            <Link to={item.href}>{item.label}</Link>
                        </li>
                    ))}
                </ul>
            </div>
            <div className="hamburger">
              <Menu/> 
            </div>
                
            <div className="toggle">
              <ToggleButton value={"check"} selected = {darkMode} onChange={toggleDarkMode}>
                    {darkMode ? <LightMode/> : <DarkMode/>}                            
              </ToggleButton>
            </div>
        </div>
    )
}

export default Navbar