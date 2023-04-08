import styles from './Indicator.module.css';

export default function Indicator({onClick,isActive}:{onClick:any|undefined,isActive:boolean|undefined}){

    let className = isActive?styles.active:styles.indicator;
    return(
        <div className={className} onClick={onClick}></div>
    );
}