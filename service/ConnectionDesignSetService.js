'use strict';


/**
 * Create or modify the connection design set
 * Create or modify the connection design set and return the updated instance from the database
 *
 * body ConDesignSet An object containing connection design set information
 * returns ConDesignSet
 **/
exports.createConDesignSet = function(body) {
  return new Promise(function(resolve, reject) {
    var examples = {};
    examples['application/json'] = {
  "owner" : "engineer",
  "name" : "name",
  "description" : "description",
  "id" : "046b6c7f-0b8a-43b9-b35d-6489e6daee91"
};
    if (Object.keys(examples).length > 0) {
      resolve(examples[Object.keys(examples)[0]]);
    } else {
      resolve();
    }
  });
}


/**
 * Delete the connection design set
 * Delete the single connection design set which is defined by passed its unique id
 *
 * id ConDesignSetId The ID of the required connection design set
 * no response value expected for this operation
 **/
exports.deleteConDesignSet = function(id) {
  return new Promise(function(resolve, reject) {
    resolve();
  });
}


/**
 * Get single connection design set by its unique id
 *
 * id ConDesignSetId The ID of the required connection design set
 * returns ConDesignSet
 **/
exports.getConDesignSet = function(id) {
  return new Promise(function(resolve, reject) {
    var examples = {};
    examples['application/json'] = {
  "owner" : "engineer",
  "name" : "name",
  "description" : "description",
  "id" : "046b6c7f-0b8a-43b9-b35d-6489e6daee91"
};
    if (Object.keys(examples).length > 0) {
      resolve(examples[Object.keys(examples)[0]]);
    } else {
      resolve();
    }
  });
}


/**
 * Get all available connection design sets for the current user
 *
 * returns List
 **/
exports.getConDesignSets = function() {
  return new Promise(function(resolve, reject) {
    var examples = {};
    examples['application/json'] = [ {
  "owner" : "engineer",
  "name" : "name",
  "description" : "description",
  "id" : "046b6c7f-0b8a-43b9-b35d-6489e6daee91"
}, {
  "owner" : "engineer",
  "name" : "name",
  "description" : "description",
  "id" : "046b6c7f-0b8a-43b9-b35d-6489e6daee91"
} ];
    if (Object.keys(examples).length > 0) {
      resolve(examples[Object.keys(examples)[0]]);
    } else {
      resolve();
    }
  });
}

