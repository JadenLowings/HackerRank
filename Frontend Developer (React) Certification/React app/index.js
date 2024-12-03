import React from "react";
import "./index.css";

function Dropdown({ options, labelText, onChange }) {

  return (
    <div className="elementSet">
      <select data-testid="dropdown" defaultValue={labelText} onChange={onChange}>
        {/* Do not remove this default option as this is needed in testing */}
        <option value={labelText} key={labelText} disabled>{labelText}</option>
        {options.map((optionValue) =>
          <option value={optionValue} key={optionValue}>{optionValue}
          </option>
        )}
      </select>
    </div>
  );
}

export default Dropdown;