// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.ShopFloorBase
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;

namespace Camstar.WCF.Services
{
  public class ShopFloorBase : UpdateBase, IShopFloorBase
  {
    protected virtual ResultStatus OnCreateParametricData(
      DCObject shopFloor,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      return this.NoMethod("CreateParametricData");
    }

    ResultStatus IShopFloorBase.CreateParametricData(
      DCObject shopFloor,
      Parameters parameters,
      Request request,
      out Result result)
    {
      return this.OnCreateParametricData(shopFloor, parameters, request, out result);
    }

    ResultStatus IShopFloorBase.CreateParametricData()
    {
      return this.Camstar\u002EWCF\u002EServices\u002EIShopFloorBase\u002ECreateParametricData((DCObject) null, (Parameters) null, (Request) null, out Result _);
    }

    ResultStatus IShopFloorBase.CreateParametricData(DCObject shopFloor)
    {
      return this.Camstar\u002EWCF\u002EServices\u002EIShopFloorBase\u002ECreateParametricData(shopFloor, (Parameters) null, (Request) null, out Result _);
    }

    ResultStatus IShopFloorBase.CreateParametricData(
      DCObject shopFloor,
      Request request,
      out Result result)
    {
      return this.Camstar\u002EWCF\u002EServices\u002EIShopFloorBase\u002ECreateParametricData(shopFloor, (Parameters) null, request, out result);
    }

    protected virtual ResultStatus OnGetActions(
      DCObject shopFloor,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      return this.NoMethod("GetActions");
    }

    ResultStatus IShopFloorBase.GetActions(
      DCObject shopFloor,
      Parameters parameters,
      Request request,
      out Result result)
    {
      return this.OnGetActions(shopFloor, parameters, request, out result);
    }

    ResultStatus IShopFloorBase.GetActions()
    {
      return this.Camstar\u002EWCF\u002EServices\u002EIShopFloorBase\u002EGetActions((DCObject) null, (Parameters) null, (Request) null, out Result _);
    }

    ResultStatus IShopFloorBase.GetActions(DCObject shopFloor)
    {
      return this.Camstar\u002EWCF\u002EServices\u002EIShopFloorBase\u002EGetActions(shopFloor, (Parameters) null, (Request) null, out Result _);
    }

    ResultStatus IShopFloorBase.GetActions(
      DCObject shopFloor,
      Request request,
      out Result result)
    {
      return this.Camstar\u002EWCF\u002EServices\u002EIShopFloorBase\u002EGetActions(shopFloor, (Parameters) null, request, out result);
    }

    protected virtual ResultStatus OnGetDataPoints(
      DCObject shopFloor,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      return this.NoMethod("GetDataPoints");
    }

    ResultStatus IShopFloorBase.GetDataPoints(
      DCObject shopFloor,
      Parameters parameters,
      Request request,
      out Result result)
    {
      return this.OnGetDataPoints(shopFloor, parameters, request, out result);
    }

    ResultStatus IShopFloorBase.GetDataPoints()
    {
      return this.Camstar\u002EWCF\u002EServices\u002EIShopFloorBase\u002EGetDataPoints((DCObject) null, (Parameters) null, (Request) null, out Result _);
    }

    ResultStatus IShopFloorBase.GetDataPoints(DCObject shopFloor)
    {
      return this.Camstar\u002EWCF\u002EServices\u002EIShopFloorBase\u002EGetDataPoints(shopFloor, (Parameters) null, (Request) null, out Result _);
    }

    ResultStatus IShopFloorBase.GetDataPoints(
      DCObject shopFloor,
      Request request,
      out Result result)
    {
      return this.Camstar\u002EWCF\u002EServices\u002EIShopFloorBase\u002EGetDataPoints(shopFloor, (Parameters) null, request, out result);
    }

    protected virtual ResultStatus OnLoadESigDetails(
      DCObject shopFloor,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      return this.NoMethod("LoadESigDetails");
    }

    ResultStatus IShopFloorBase.LoadESigDetails(
      DCObject shopFloor,
      Parameters parameters,
      Request request,
      out Result result)
    {
      return this.OnLoadESigDetails(shopFloor, parameters, request, out result);
    }

    ResultStatus IShopFloorBase.LoadESigDetails()
    {
      return this.Camstar\u002EWCF\u002EServices\u002EIShopFloorBase\u002ELoadESigDetails((DCObject) null, (Parameters) null, (Request) null, out Result _);
    }

    ResultStatus IShopFloorBase.LoadESigDetails(DCObject shopFloor)
    {
      return this.Camstar\u002EWCF\u002EServices\u002EIShopFloorBase\u002ELoadESigDetails(shopFloor, (Parameters) null, (Request) null, out Result _);
    }

    ResultStatus IShopFloorBase.LoadESigDetails(
      DCObject shopFloor,
      Request request,
      out Result result)
    {
      return this.Camstar\u002EWCF\u002EServices\u002EIShopFloorBase\u002ELoadESigDetails(shopFloor, (Parameters) null, request, out result);
    }

    protected virtual ResultStatus OnProcessComputation(
      DCObject shopFloor,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      return this.NoMethod("ProcessComputation");
    }

    ResultStatus IShopFloorBase.ProcessComputation(
      DCObject shopFloor,
      Parameters parameters,
      Request request,
      out Result result)
    {
      return this.OnProcessComputation(shopFloor, parameters, request, out result);
    }

    ResultStatus IShopFloorBase.ProcessComputation()
    {
      return this.Camstar\u002EWCF\u002EServices\u002EIShopFloorBase\u002EProcessComputation((DCObject) null, (Parameters) null, (Request) null, out Result _);
    }

    ResultStatus IShopFloorBase.ProcessComputation(DCObject shopFloor)
    {
      return this.Camstar\u002EWCF\u002EServices\u002EIShopFloorBase\u002EProcessComputation(shopFloor, (Parameters) null, (Request) null, out Result _);
    }

    ResultStatus IShopFloorBase.ProcessComputation(
      DCObject shopFloor,
      Request request,
      out Result result)
    {
      return this.Camstar\u002EWCF\u002EServices\u002EIShopFloorBase\u002EProcessComputation(shopFloor, (Parameters) null, request, out result);
    }

    protected virtual ResultStatus OnResolveParametricData(
      DCObject shopFloor,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      return this.NoMethod("ResolveParametricData");
    }

    ResultStatus IShopFloorBase.ResolveParametricData(
      DCObject shopFloor,
      Parameters parameters,
      Request request,
      out Result result)
    {
      return this.OnResolveParametricData(shopFloor, parameters, request, out result);
    }

    ResultStatus IShopFloorBase.ResolveParametricData()
    {
      return this.Camstar\u002EWCF\u002EServices\u002EIShopFloorBase\u002EResolveParametricData((DCObject) null, (Parameters) null, (Request) null, out Result _);
    }

    ResultStatus IShopFloorBase.ResolveParametricData(DCObject shopFloor)
    {
      return this.Camstar\u002EWCF\u002EServices\u002EIShopFloorBase\u002EResolveParametricData(shopFloor, (Parameters) null, (Request) null, out Result _);
    }

    ResultStatus IShopFloorBase.ResolveParametricData(
      DCObject shopFloor,
      Request request,
      out Result result)
    {
      return this.Camstar\u002EWCF\u002EServices\u002EIShopFloorBase\u002EResolveParametricData(shopFloor, (Parameters) null, request, out result);
    }
  }
}
