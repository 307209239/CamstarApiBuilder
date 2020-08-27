// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.TrackTargetDeploymentBase
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;

namespace Camstar.WCF.Services
{
  public class TrackTargetDeploymentBase : ShopFloorBase, ITrackTargetDeploymentBase
  {
    protected virtual ResultStatus OnGetNextAvailableTargetDeployment(
      DCObject trackTargetDeployment,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      return this.NoMethod("GetNextAvailableTargetDeployment");
    }

    ResultStatus ITrackTargetDeploymentBase.GetNextAvailableTargetDeployment(
      DCObject trackTargetDeployment,
      Parameters parameters,
      Request request,
      out Result result)
    {
      return this.OnGetNextAvailableTargetDeployment(trackTargetDeployment, parameters, request, out result);
    }

    ResultStatus ITrackTargetDeploymentBase.GetNextAvailableTargetDeployment()
    {
      return this.Camstar\u002EWCF\u002EServices\u002EITrackTargetDeploymentBase\u002EGetNextAvailableTargetDeployment((DCObject) null, (Parameters) null, (Request) null, out Result _);
    }

    ResultStatus ITrackTargetDeploymentBase.GetNextAvailableTargetDeployment(
      DCObject trackTargetDeployment)
    {
      return this.Camstar\u002EWCF\u002EServices\u002EITrackTargetDeploymentBase\u002EGetNextAvailableTargetDeployment(trackTargetDeployment, (Parameters) null, (Request) null, out Result _);
    }

    ResultStatus ITrackTargetDeploymentBase.GetNextAvailableTargetDeployment(
      DCObject trackTargetDeployment,
      Request request,
      out Result result)
    {
      return this.Camstar\u002EWCF\u002EServices\u002EITrackTargetDeploymentBase\u002EGetNextAvailableTargetDeployment(trackTargetDeployment, (Parameters) null, request, out result);
    }
  }
}
