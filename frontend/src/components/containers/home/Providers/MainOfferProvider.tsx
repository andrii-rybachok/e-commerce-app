import IProductPreview from "@/types/products/product/IProductPreview";
import axios from "axios";
import React, { useContext, useEffect, useState } from "react";

const Context = React.createContext<IProductPreview[]>([]);

export const MainOfferDataProvider = ({ children }:any) => {
  const [comments, setComments] = useState<IProductPreview[]>([]);

  useEffect( () => {
    async function foo() {  
      const {data}= await axios.get<IProductPreview[]>("https://localhost:7100/api/shop/promoted");

    setComments(data);
    }
    foo();
  }, [])

  return (
    <Context.Provider value={comments}>
      {children}
    </Context.Provider>
  )
}

export const useMainOffer = () => useContext(Context);