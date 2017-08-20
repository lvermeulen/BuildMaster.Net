param (
	[string]$BuildVersionNumber=$(throw "-BuildVersionNumber is required."),
	[string]$TagVersionNumber
)

& dotnet restore --no-cache

foreach ($src in ls $PSScriptRoot\..\src/*) {
    Push-Location $src

	echo "build: Building & packaging project in $src"

    & dotnet build -c Release --version-suffix=$BuildVersionNumber
    & dotnet pack -c Release --include-symbols -o ..\..\artifacts --version-suffix=$BuildVersionNumber --no-build
    if($LASTEXITCODE -ne 0) { exit 1 }    

    Pop-Location
}
