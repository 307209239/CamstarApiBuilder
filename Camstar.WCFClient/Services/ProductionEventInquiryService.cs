// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.ProductionEventInquiryService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class ProductionEventInquiryService : InquiryBase
  {
    public ProductionEventInquiryService(UserProfile userProfile)
    {
      this.Initialize(typeof (IProductionEventInquiryService), userProfile);
    }

    public ResultStatus GetWIPMsgs(
      ProductionEventInquiry productionEventInquiry,
      ProductionEventInquiry_Parameters parameters,
      ProductionEventInquiry_Request request,
      out ProductionEventInquiry_Result result)
    {
      result = (ProductionEventInquiry_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) productionEventInquiry, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IProductionEventInquiryService) this._Channel).GetWIPMsgs(this._UserProfile, productionEventInquiry, parameters, request, out result) : this.AddMethod((Method) new ProductionEventInquiryMethod(productionEventInquiry, ProductionEventInquiryMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) productionEventInquiry, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((ProductionEventInquiry) null, (ProductionEventInquiry_Parameters) null, (ProductionEventInquiry_Request) null, out ProductionEventInquiry_Result _);
    }

    public ResultStatus GetWIPMsgs(ProductionEventInquiry productionEventInquiry)
    {
      return this.GetWIPMsgs(productionEventInquiry, (ProductionEventInquiry_Parameters) null, (ProductionEventInquiry_Request) null, out ProductionEventInquiry_Result _);
    }

    public ResultStatus GetWIPMsgs(
      ProductionEventInquiry productionEventInquiry,
      ProductionEventInquiry_Request request,
      out ProductionEventInquiry_Result result)
    {
      return this.GetWIPMsgs(productionEventInquiry, (ProductionEventInquiry_Parameters) null, request, out result);
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject productionEventInquiry,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ProductionEventInquiry_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((ProductionEventInquiry) productionEventInquiry, (ProductionEventInquiry_Parameters) parameters, (ProductionEventInquiry_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      ProductionEventInquiry_Request request,
      out ProductionEventInquiry_Result result)
    {
      result = (ProductionEventInquiry_Result) null;
      try
      {
        ProductionEventInquiryMethod[] methods = new ProductionEventInquiryMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((IProductionEventInquiryService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnCommitTransaction(
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ProductionEventInquiry_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((ProductionEventInquiry_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      ProductionEventInquiry cdo,
      ProductionEventInquiry_Request request,
      out ProductionEventInquiry_Result result)
    {
      result = (ProductionEventInquiry_Result) null;
      try
      {
        return ((IProductionEventInquiryService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetEnvironment(
      DCObject cdo,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ProductionEventInquiry_Result result1;
        ResultStatus environment = this.GetEnvironment((ProductionEventInquiry) cdo, (ProductionEventInquiry_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      ProductionEventInquiry_Request request,
      out ProductionEventInquiry_Result result)
    {
      return this.GetEnvironment((ProductionEventInquiry) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      ProductionEventInquiry cdo,
      ProductionEventInquiry_Request request,
      out ProductionEventInquiry_Result result)
    {
      result = (ProductionEventInquiry_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IProductionEventInquiryService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new ProductionEventInquiryMethod(cdo, ProductionEventInquiryMethods.ExecuteTransaction, (ProductionEventInquiry_Parameters) null));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ExecuteTransaction), res, (DCObject) cdo, (Parameters) null, (Request) request, (Result) result);
      return res;
    }

    protected override ResultStatus OnExecuteTransaction(
      DCObject cdo,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ProductionEventInquiry_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((ProductionEventInquiry) cdo, (ProductionEventInquiry_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(ProductionEventInquiry cdo)
    {
      return this.ExecuteTransaction(cdo, (ProductionEventInquiry_Request) null, out ProductionEventInquiry_Result _);
    }

    public ResultStatus ExecuteTransaction(
      ProductionEventInquiry_Request request,
      out ProductionEventInquiry_Result result)
    {
      return this.ExecuteTransaction((ProductionEventInquiry) null, request, out result);
    }

    public ResultStatus AddDataTransaction(ProductionEventInquiry cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new ProductionEventInquiryMethod(cdo, ProductionEventInquiryMethods.AddDataTransaction, (ProductionEventInquiry_Parameters) null));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
      {
        Result result;
        this.OnAfterCall(nameof (AddDataTransaction), res, (DCObject) cdo, (Parameters) null, (Request) null, result);
      }
      return res;
    }

    protected override ResultStatus OnAddDataTransaction(DCObject cdo)
    {
      try
      {
        return this.AddDataTransaction((ProductionEventInquiry) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}
