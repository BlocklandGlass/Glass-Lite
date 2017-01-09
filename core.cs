function Glass::init() {
	if(!isObject(Glass)) {
		new ScriptObject(Glass) {
			version = "4.0.0-lite";
			address = "api.blocklandglass.com"; //api address
			netAddress = "blocklandglass.com"; //url address
			enableCLI = true;

			liveAddress = "blocklandglass.com";
			livePort = 27002;
		};
	}

  Glass::execServer();
}

function JettisonObject::get(%this, %key) {
	return %this.value[%key];
}