const calcDiff = (date) => {
  const ONE_DAY = 1000 * 1000 * 60 * 60 * 24
  let diff = Math.abs(date - Date.now())
  return Math.round(diff / ONE_DAY)
}

const listLaunches = (data) => {
  if (data && data.length) data.forEach(el => {
    var str = el.name
    str += "\n -Vuelo nro: " + el.flight_number
    str += "\n -Fecha de lanzamiento: " + el.date_utc
    str += "\n -Faltan: " + calcDiff(el.date_unix) + " dias"
    
    console.log(str)
  })
}

const getUpcomingLaunches = () => {
  const url = 'https://api.spacexdata.com/v4/launches/upcoming'
  fetch(url)
    .then(res => res.json())
    .then(data => {
      const length = data && data.length
      console.log('Data Length: '+ length)
      if(length) return listLaunches(data)
    })
}

getUpcomingLaunches()