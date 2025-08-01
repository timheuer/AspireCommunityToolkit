﻿using Aspire.Hosting.ApplicationModel;

namespace CommunityToolkit.Aspire.Hosting.Dapr;

internal record DaprComponentSecretAnnotation(string Key, ParameterResource Value) : IResourceAnnotation;
