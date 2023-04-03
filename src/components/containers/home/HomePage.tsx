import MainOffer from "@/components/containers/home/mainOffer/MainOffer";
import ProductPlate from "@/components/productTale/ProductPlate";
import IProductPreview from '@/types/products/product/IProductPreview';

export default function HomePage(){
    let test:IProductPreview={
        id:1,
        name:"Sony",
        previewImage:"https://localhost:7100/images/big/1_1.jpg",
        rating:5,
        secondImage:"null",
        price:300
    }
    return (
        <>
            <MainOffer></MainOffer>
            <ProductPlate product={test}/>
        </>
    );
}