<?php

require_once 'server.php';

$server = new TestTCPServer();
$server->run(function($remote, $line, $sock) {
    socket_write($remote, $line);
});