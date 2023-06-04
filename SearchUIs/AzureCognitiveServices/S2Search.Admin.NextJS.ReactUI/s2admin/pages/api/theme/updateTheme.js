import { handleResponse, handleError, apiOptionsWithData } from "../apiUtils";
const baseUrl = `${process.env.NEXT_PUBLIC_S2_CUSTOMER_RESOURCE_ENDPOINT}/${process.env.NEXT_PUBLIC_S2_CUSTOMER_RESOURCE_CUSTOMERS_URL}`;

export async function updateTheme(customerId, searchIndexId, data) {
  const url = `${baseUrl}/${customerId}/searchindex/${searchIndexId}/theme/update`;
  const putMethod = apiOptionsWithData("PUT", data);
  return await fetch(url, putMethod).then(handleResponse).catch(handleError);
}

export default function index(req, res) {
  try {
    const customerId = req.query.customerId;
    const searchIndexId = req.query.searchIndexId;
    const data = req.body;

    updateTheme(customerId, searchIndexId, data).then(function (data) {
      res.status(200).json(data);
    });
  } catch (e) {
    console.log(e);
    res.status(500).json(e);
  }
}
