'use strict';


/**
 * Get information about the current user
 *
 * returns User
 **/
exports.getUser = function() {
  return new Promise(function(resolve, reject) {
    var examples = {};
    examples['application/json'] = {
  "role" : "engineer",
  "name" : "name"
};
    if (Object.keys(examples).length > 0) {
      resolve(examples[Object.keys(examples)[0]]);
    } else {
      resolve();
    }
  });
}

