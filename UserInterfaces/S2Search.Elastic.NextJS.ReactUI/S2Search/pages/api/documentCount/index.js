const { genericAPI } = require("../shared/genericAPI");
module.exports = async function (req, res) {
  return await genericAPI(req, res, "documentCount", "", true);
};
