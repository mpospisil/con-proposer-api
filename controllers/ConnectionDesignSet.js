'use strict';

var utils = require('../utils/writer.js');
var ConnectionDesignSet = require('../service/ConnectionDesignSetService');

module.exports.createConDesignSet = function createConDesignSet (req, res, next, body) {
  ConnectionDesignSet.createConDesignSet(body)
    .then(function (response) {
      utils.writeJson(res, response);
    })
    .catch(function (response) {
      utils.writeJson(res, response);
    });
};

module.exports.deleteConDesignSet = function deleteConDesignSet (req, res, next, id) {
  ConnectionDesignSet.deleteConDesignSet(id)
    .then(function (response) {
      utils.writeJson(res, response);
    })
    .catch(function (response) {
      utils.writeJson(res, response);
    });
};

module.exports.getConDesignSet = function getConDesignSet (req, res, next, id) {
  ConnectionDesignSet.getConDesignSet(id)
    .then(function (response) {
      utils.writeJson(res, response);
    })
    .catch(function (response) {
      utils.writeJson(res, response);
    });
};

module.exports.getConDesignSets = function getConDesignSets (req, res, next) {
  ConnectionDesignSet.getConDesignSets()
    .then(function (response) {
      utils.writeJson(res, response);
    })
    .catch(function (response) {
      utils.writeJson(res, response);
    });
};
