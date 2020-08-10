// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Messaging.EventGrid.SystemEvents
{
    public partial class AppServicePlanEventTypeDetail
    {
        internal static AppServicePlanEventTypeDetail DeserializeAppServicePlanEventTypeDetail(JsonElement element)
        {
            Optional<StampKind> stampKind = default;
            Optional<AppServicePlanAction> action = default;
            Optional<AsyncStatus> status = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("stampKind"))
                {
                    stampKind = new StampKind(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("action"))
                {
                    action = new AppServicePlanAction(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("status"))
                {
                    status = new AsyncStatus(property.Value.GetString());
                    continue;
                }
            }
            return new AppServicePlanEventTypeDetail(Optional.ToNullable(stampKind), Optional.ToNullable(action), Optional.ToNullable(status));
        }
    }
}