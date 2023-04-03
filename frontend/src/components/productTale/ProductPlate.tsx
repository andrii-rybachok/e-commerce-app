import { FontAwesomeIcon } from '@fortawesome/react-fontawesome'
import { solid ,regular} from '@fortawesome/fontawesome-svg-core/import.macro'
import IProductPreview from '@/types/products/product/IProductPreview';
import styles from './ProductPlate.module.css';
import { useRef } from 'react';
import { forEachChild } from 'typescript';

export default function ProductPlate({product}:{product:IProductPreview}){
    const stars = [
        <FontAwesomeIcon icon={solid("star")} />,
        <FontAwesomeIcon icon={solid("star")} />,
        <FontAwesomeIcon icon={solid("star")} />,
        <FontAwesomeIcon icon={solid("star")} />,
        <FontAwesomeIcon icon={solid("star")} />,
    ]
    return(
        <div className={styles.plate}>
            <button className={styles.likeBtn}><FontAwesomeIcon icon={solid("heart")} /></button>
            <img src={product.previewImage} alt="" className={styles.previewImage}/>
            <h4 className={styles.name}>{product.name}</h4>
            <span className={styles.price}>${product.price}</span>
            <div className={styles.stars} >
                {stars}
            </div>
        </div>
    );
}