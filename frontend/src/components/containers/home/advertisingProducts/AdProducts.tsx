import IProductPreview from "@/types/products/product/IProductPreview";
import productStyles from './LongPlate.module.css';
import bigStyles from './BigPlate.module.css';
import { FontAwesomeIcon } from '@fortawesome/react-fontawesome'
import { solid ,regular} from '@fortawesome/fontawesome-svg-core/import.macro'
import { useMainOffer } from "../providers/MainOfferProvider";
import { useState } from "react";
import Indicator from "@/components/indicator/Indicator";
import usePagination from "@/customHooks/usePagination";
import useStars from "@/customHooks/useStars";

export default function AdProducts(){
    const products = useMainOffer();
    const pageSystem = usePagination({maxItemsOnPage:1,
      itemsLength:2}); 
      let product = products.at(pageSystem.pagination.currentPage);
      var stars = useStars({rating:product?.rating});
    if(products.length===0 &&products!=undefined) return (<h1>Loading...</h1>)

    
    return (
      <>
        <section className={bigStyles.block}>
          <div className={bigStyles.bigPlate}>
            <div className={bigStyles.imageBlock}>
              <img
                src={
                  "https://localhost:7100/images/big/" + product?.previewImage
                }
                alt=""
                className={bigStyles.previewImage}
              />
            </div>
            <div>
              <a className={bigStyles.name}>{product?.name}</a>
              <span className={productStyles.price}>${product?.price}</span>
              <div className={productStyles.stars}>{stars}</div>
              <div className={bigStyles.buttons}>
                <button className={bigStyles.bigBtn}>
                  Add to cart
                  <span>
                    <FontAwesomeIcon icon={solid("cart-shopping")} />
                  </span>
                </button>
                <button className={bigStyles.smallBtn}>
                  <FontAwesomeIcon icon={solid("eye")} />
                </button>
              </div>
              <div className={bigStyles.indicators}>
                {pageSystem.indicators}
              </div>
            </div>
          </div>
          <div>
            <LongProductPlate product={products.at(1)} />
            <LongProductPlate product={products.at(2)} />
          </div>
        </section>
      </>
    );
}

function LongProductPlate({product}:{product:IProductPreview|any}){
  const stars=useStars({rating:product.rating})
  return (
    <div className={productStyles.plate}>
      <div className={productStyles.imgBlock}>
        <img
          src={"https://localhost:7100/images/big/" + product.previewImage}
          alt=""
          className={productStyles.previewImage}
        />
      </div>
      <div>
          <a className={productStyles.name}>{product.name}</a>
          <span className={productStyles.price}>${product.price}</span>
          <div className={productStyles.stars}>{stars}</div>
      </div>
    </div>
  );
}
