import { Outlet } from "react-router-dom";
import DefaultHeader from "./DefaultHeader";


export default function DefaultLayout(){
    return(
        <>             
            <DefaultHeader/>
            <main>
               <Outlet/>
            </main>
        </>
    );
}