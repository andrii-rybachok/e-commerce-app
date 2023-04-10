import { FontAwesomeIcon } from '@fortawesome/react-fontawesome'
import { solid ,regular} from '@fortawesome/fontawesome-svg-core/import.macro'
import IProductPreview from '@/types/products/product/IProductPreview';
import styles from './ProductPlate.module.css';
import { useRef, useState } from 'react';
import { forEachChild } from 'typescript';
import useStars from '@/customHooks/useStars';

export default function ProductPlate({product}:{product:IProductPreview}){
    const [over, setOver] = useState(false);
    const stars = useStars({rating:product.rating});
    let imageName = over?product.secondImage:product.previewImage;
    return(
        <div className={styles.plate} onMouseOver={()=>setOver(true)} onMouseOut={()=>setOver(false)}>
            <button className={styles.likeBtn}><FontAwesomeIcon icon={solid("heart")} /></button>
            <img src={"https://localhost:7100/images/big/"+imageName} alt="" className={styles.previewImage}/>
            <a className={styles.name}>{product.name}</a>
            <span className={styles.price}>${product.price}</span>
            <div className={styles.stars} >
                {stars}
            </div>
        </div>
    );
}