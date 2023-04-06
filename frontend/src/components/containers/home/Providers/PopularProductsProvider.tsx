import IProductPreview from "@/types/products/product/IProductPreview";
import axios from "axios";
import React, { useContext, useEffect, useState } from "react";

const Context = React.createContext<IProductPreview[]>([]);

export const PopularProductsDataProvider = ({ children }:any) => {
  const [comments, setComments] = useState<IProductPreview[]>([]);
  const initialCategory="Headphones";
  useEffect( () => {
    async function foo() {  
      const {data}= await axios.get<IProductPreview[]>("https://localhost:7100/api/shop/popular",{params:{categoryName:initialCategory}});

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

export const usePopProducts = () => useContext(Context);