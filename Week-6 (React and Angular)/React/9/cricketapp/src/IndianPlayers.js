export const IndianTeam = [
  "Sachin",
  "Dhoni",
  "Virat",
  "Rohit",
  "Yuvraj",
  "Raina"
];

export function OddPlayers([first, second, third, fourth, fifth, sixth]) {

  return (
    <div>
      <p>First : {first}</p>
      <p>Third : {third}</p>
      <p>Fifth : {fifth}</p>
    </div>
  );

}

export function EvenPlayers([first, second, third, fourth, fifth, sixth]) {

  return (
    <div>
      <p>Second : {second}</p>
      <p>Fourth : {fourth}</p>
      <p>Sixth : {sixth}</p>
    </div>
  );

}

const T20Players = [
  "First Player",
  "Second Player",
  "Third Player"
];

const RanjiTrophyPlayers = [
  "Fourth Player",
  "Fifth Player",
  "Sixth Player"
];

export const IndianPlayers = [
  ...T20Players,
  ...RanjiTrophyPlayers
];

export function ListofIndianPlayers({ IndianPlayers }) {

  return (
    <ul>
      {
        IndianPlayers.map((item, index) => (
          <li key={index}>Mr. {item}</li>
        ))
      }
    </ul>
  );

}