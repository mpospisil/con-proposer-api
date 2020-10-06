'use strict';

var utils = require('../utils/writer.js');
var ConnectionDesignItem = require('../service/ConnectionDesignItemService');

module.exports.deleteConDesignItem = function deleteConDesignItem (req, res, next, id) {
  ConnectionDesignItem.deleteConDesignItem(id)
    .then(function (response) {
      utils.writeJson(res, response);
    })
    .catch(function (response) {
      utils.writeJson(res, response);
    });
};

module.exports.getConDesignItem = function getConDesignItem (req, res, next, id) {
  ConnectionDesignItem.getConDesignItem(id)
    .then(function (response) {
      utils.writeJson(res, response);
    })
    .catch(function (response) {
      utils.writeJson(res, response);
    });
};

module.exports.getConDesignItems = function getConDesignItems (req, res, next, id) {
  ConnectionDesignItem.getConDesignItems(id)
    .then(function (response) {
      utils.writeJson(res, response);
    })
    .catch(function (response) {
      utils.writeJson(res, response);
    });
};

module.exports.postConDesignItem = function postConDesignItem (req, res, next, body) {
  ConnectionDesignItem.postConDesignItem(body)
    .then(function (response) {
      utils.writeJson(res, response);
    })
    .catch(function (response) {
      utils.writeJson(res, response);
    });
};

module.exports.project_publishPOST = function project_publishPOST (req, res, next) {
  ConnectionDesignItem.project_publishPOST()
    .then(function (response) {
      utils.writeJson(res, response);
    })
    .catch(function (response) {
      utils.writeJson(res, response);
    });
};
