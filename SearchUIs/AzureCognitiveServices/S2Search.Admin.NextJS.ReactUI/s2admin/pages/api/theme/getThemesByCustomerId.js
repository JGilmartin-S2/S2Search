import { handleResponse, handleError, apiOptions } from "../apiUtils";
const baseUrl = `${process.env.NEXT_PUBLIC_S2_CUSTOMER_RESOURCE_ENDPOINT}/${process.env.NEXT_PUBLIC_S2_CUSTOMER_RESOURCE_CUSTOMERS_URL}`;

export async function getThemesByCustomerId(customerId, searchIndexId) {
  const url = `${baseUrl}/${customerId}/searchindex/${searchIndexId}/theme/all`;
  return await fetch(url, apiOptions("GET"))
    .then(handleResponse)
    .catch(handleError);
}

export default function index(req, res) {
  try {
    const customerId = req.query.customerId;
    const searchIndexId = req.query.searchIndexId;
    const themeId = req.query.themeId;

    getThemesByCustomerId(customerId, searchIndexId, themeId).then(function (
      data
    ) {
      res.status(200).json(data);
    });
  } catch (e) {
    console.log(e);
    res.status(500).json(e);
  }
}
