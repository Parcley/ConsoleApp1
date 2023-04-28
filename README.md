We are using sonarscanner to analyze our project on our SonarQube CE Server. The command in CI looks like this:

```
"dotnet sonarscanner begin /k:"${SONAR_PROJECT_KEY}" /d:sonar.login="$SONAR_TOKEN" /d:"sonar.host.url=${SONAR_HOST_URL}" /d:sonar.coverageReportPaths="./testcoverage/SonarQube.xml" /d:sonar.cs.vstest.reportsPaths="./${DOTNET_TEST_PROJECT_NAME}/TestResults/TestResults.trx" /d:sonar.qualitygate.timeout=300 /d:sonar.qualitygate.wait=true"

reportgenerator "-reports:./${DOTNET_TEST_PROJECT_NAME}/TestResults/*/coverage.cobertura.xml" "-targetdir:testcoverage" "-reporttypes:SonarQube"

dotnet sonarscanner end /d:sonar.login="$SONAR_TOKEN"
```