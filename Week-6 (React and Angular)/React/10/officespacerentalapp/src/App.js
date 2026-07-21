import office from "./office.jpg";

function App() {

  const heading = "Office Space";

  const officeSpaces = [
    {
      Name: "DBS",
      Rent: 50000,
      Address: "Chennai",
      Image: office
    },
    {
      Name: "Regus",
      Rent: 65000,
      Address: "Bangalore",
      Image: office
    },
    {
      Name: "WeWork",
      Rent: 80000,
      Address: "Hyderabad",
      Image: office
    }
  ];

  return (
    <div style={{ margin: "30px" }}>

      <h1>{heading}, at Affordable Range</h1>

      {
        officeSpaces.map((item, index) => {

          const rentStyle = {
            color: item.Rent <= 60000 ? "red" : "green"
          };

          return (
            <div key={index} style={{ marginBottom: "30px" }}>

              <img
                src={item.Image}
                alt="Office Space"
                width="25%"
                height="25%"
              />

              <h2>Name: {item.Name}</h2>

              <h3 style={rentStyle}>
                Rent: Rs. {item.Rent}
              </h3>

              <h3>
                Address: {item.Address}
              </h3>

            </div>
          );
        })
      }

    </div>
  );
}

export default App;