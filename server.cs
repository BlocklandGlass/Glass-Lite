if(isFile("Add-Ons/System_BlocklandGlass/core.cs")) {
  error("Full Blockland Glass installation detected - will not run until System_BlocklandGlass removed.");
  return;
}

exec("./core.cs");

function Glass::execServer() {
	echo(" ===  Blockland Glass v" @ Glass.version @ " preparing for startup.  ===");
	exec("./support/Support_TCPClient.cs");
	exec("./support/jettison.cs");

	echo(" ===              Executing Important Stuff             ===");
	exec("./server/GlassAuth.cs");
	exec("./server/GlassServerImage.cs");

	echo(" ===                   Starting it up                   ===");

	GlassAuthS::init();
}

if($Server::Dedicated) {
	Glass::init("dedicated");
} else {
	Glass::init("server");
}