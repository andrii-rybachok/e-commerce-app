import IProductPreview from "@/types/products/product/IProductPreview";
import productStyles from './LongPlate.module.css';
import bigStyles from './BigPlate.module.css';
import { FontAwesomeIcon } from '@fortawesome/react-fontawesome'
import { solid ,regular} from '@fortawesome/fontawesome-svg-core/import.macro'
import { useMainOffer } from "../providers/MainOfferProvider";
import { useState } from "react";
import Indicator from "@/components/indicator/Indicator";

export default function AdProducts(){
    const products = useMainOffer();
    const [currentImg, setCurrentImg] = useState<number>(0);
    function handleSlide(id:number){
      setCurrentImg(id);       
      // fadeInScrollItems();     
  }
  
    if(products.length===0 &&products!=undefined) return (<h1>Loading...</h1>);
    const indicators = [];
    for (let index = 0; index < 2; index++) {
        let isActive = currentImg===index?true:false;
        indicators.push(     
            <Indicator key={index} isActive={isActive} onClick={()=>handleSlide(index)}/>
        )
    }
    let product = products.at(currentImg);
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
                {indicators}
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
const stars = [
  <FontAwesomeIcon icon={solid("star")} />,
  <FontAwesomeIcon icon={solid("star")} />,
  <FontAwesomeIcon icon={solid("star")} />,
  <FontAwesomeIcon icon={solid("star")} />,
  <FontAwesomeIcon icon={solid("star")} />,
];
function LongProductPlate({product}:{product:IProductPreview|any}){
  return (
    <div className={productStyles.plate}>
      <img
        src={"https://localhost:7100/images/big/" + product.previewImage}
        alt=""
        className={productStyles.previewImage}
      />
      <div>
          <a className={productStyles.name}>{product.name}</a>
          <span className={productStyles.price}>${product.price}</span>
          <div className={productStyles.stars}>{stars}</div>
      </div>
    </div>
  );
}
