// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.UIProviderComponentInquiryService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class UIProviderComponentInquiryService : InquiryBase
  {
    public UIProviderComponentInquiryService(UserProfile userProfile)
    {
      this.Initialize(typeof (IUIProviderComponentInquiryService), userProfile);
    }

    public ResultStatus GetPageFlowContentByGUID(
      UIProviderComponentInquiry uIProviderComponentInquiry,
      UIProviderComponentInquiry_Parameters parameters,
      UIProviderComponentInquiry_Request request,
      out UIProviderComponentInquiry_Result result)
    {
      result = (UIProviderComponentInquiry_Result) null;
      this.OnBeforeCall(nameof (GetPageFlowContentByGUID), (DCObject) uIProviderComponentInquiry, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IUIProviderComponentInquiryService) this._Channel).GetPageFlowContentByGUID(this._UserProfile, uIProviderComponentInquiry, parameters, request, out result) : this.AddMethod((Method) new UIProviderComponentInquiryMethod(uIProviderComponentInquiry, UIProviderComponentInquiryMethods.GetPageFlowContentByGUID, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetPageFlowContentByGUID), res, (DCObject) uIProviderComponentInquiry, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetPageFlowContentByGUID()
    {
      return this.GetPageFlowContentByGUID((UIProviderComponentInquiry) null, (UIProviderComponentInquiry_Parameters) null, (UIProviderComponentInquiry_Request) null, out UIProviderComponentInquiry_Result _);
    }

    public ResultStatus GetPageFlowContentByGUID(
      UIProviderComponentInquiry uIProviderComponentInquiry)
    {
      return this.GetPageFlowContentByGUID(uIProviderComponentInquiry, (UIProviderComponentInquiry_Parameters) null, (UIProviderComponentInquiry_Request) null, out UIProviderComponentInquiry_Result _);
    }

    public ResultStatus GetPageFlowContentByGUID(
      UIProviderComponentInquiry uIProviderComponentInquiry,
      UIProviderComponentInquiry_Request request,
      out UIProviderComponentInquiry_Result result)
    {
      return this.GetPageFlowContentByGUID(uIProviderComponentInquiry, (UIProviderComponentInquiry_Parameters) null, request, out result);
    }

    public ResultStatus GetPersonalizationContentByOwner(
      UIProviderComponentInquiry uIProviderComponentInquiry,
      UIProviderComponentInquiry_Parameters parameters,
      UIProviderComponentInquiry_Request request,
      out UIProviderComponentInquiry_Result result)
    {
      result = (UIProviderComponentInquiry_Result) null;
      this.OnBeforeCall(nameof (GetPersonalizationContentByOwner), (DCObject) uIProviderComponentInquiry, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IUIProviderComponentInquiryService) this._Channel).GetPersonalizationContentByOwner(this._UserProfile, uIProviderComponentInquiry, parameters, request, out result) : this.AddMethod((Method) new UIProviderComponentInquiryMethod(uIProviderComponentInquiry, UIProviderComponentInquiryMethods.GetPersonalizationContentByOwner, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetPersonalizationContentByOwner), res, (DCObject) uIProviderComponentInquiry, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetPersonalizationContentByOwner()
    {
      return this.GetPersonalizationContentByOwner((UIProviderComponentInquiry) null, (UIProviderComponentInquiry_Parameters) null, (UIProviderComponentInquiry_Request) null, out UIProviderComponentInquiry_Result _);
    }

    public ResultStatus GetPersonalizationContentByOwner(
      UIProviderComponentInquiry uIProviderComponentInquiry)
    {
      return this.GetPersonalizationContentByOwner(uIProviderComponentInquiry, (UIProviderComponentInquiry_Parameters) null, (UIProviderComponentInquiry_Request) null, out UIProviderComponentInquiry_Result _);
    }

    public ResultStatus GetPersonalizationContentByOwner(
      UIProviderComponentInquiry uIProviderComponentInquiry,
      UIProviderComponentInquiry_Request request,
      out UIProviderComponentInquiry_Result result)
    {
      return this.GetPersonalizationContentByOwner(uIProviderComponentInquiry, (UIProviderComponentInquiry_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      UIProviderComponentInquiry uIProviderComponentInquiry,
      UIProviderComponentInquiry_Parameters parameters,
      UIProviderComponentInquiry_Request request,
      out UIProviderComponentInquiry_Result result)
    {
      result = (UIProviderComponentInquiry_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) uIProviderComponentInquiry, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IUIProviderComponentInquiryService) this._Channel).GetWIPMsgs(this._UserProfile, uIProviderComponentInquiry, parameters, request, out result) : this.AddMethod((Method) new UIProviderComponentInquiryMethod(uIProviderComponentInquiry, UIProviderComponentInquiryMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) uIProviderComponentInquiry, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((UIProviderComponentInquiry) null, (UIProviderComponentInquiry_Parameters) null, (UIProviderComponentInquiry_Request) null, out UIProviderComponentInquiry_Result _);
    }

    public ResultStatus GetWIPMsgs(
      UIProviderComponentInquiry uIProviderComponentInquiry)
    {
      return this.GetWIPMsgs(uIProviderComponentInquiry, (UIProviderComponentInquiry_Parameters) null, (UIProviderComponentInquiry_Request) null, out UIProviderComponentInquiry_Result _);
    }

    public ResultStatus GetWIPMsgs(
      UIProviderComponentInquiry uIProviderComponentInquiry,
      UIProviderComponentInquiry_Request request,
      out UIProviderComponentInquiry_Result result)
    {
      return this.GetWIPMsgs(uIProviderComponentInquiry, (UIProviderComponentInquiry_Parameters) null, request, out result);
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject uIProviderComponentInquiry,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        UIProviderComponentInquiry_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((UIProviderComponentInquiry) uIProviderComponentInquiry, (UIProviderComponentInquiry_Parameters) parameters, (UIProviderComponentInquiry_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      UIProviderComponentInquiry_Request request,
      out UIProviderComponentInquiry_Result result)
    {
      result = (UIProviderComponentInquiry_Result) null;
      try
      {
        UIProviderComponentInquiryMethod[] methods = new UIProviderComponentInquiryMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((IUIProviderComponentInquiryService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        UIProviderComponentInquiry_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((UIProviderComponentInquiry_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      UIProviderComponentInquiry cdo,
      UIProviderComponentInquiry_Request request,
      out UIProviderComponentInquiry_Result result)
    {
      result = (UIProviderComponentInquiry_Result) null;
      try
      {
        return ((IUIProviderComponentInquiryService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        UIProviderComponentInquiry_Result result1;
        ResultStatus environment = this.GetEnvironment((UIProviderComponentInquiry) cdo, (UIProviderComponentInquiry_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      UIProviderComponentInquiry_Request request,
      out UIProviderComponentInquiry_Result result)
    {
      return this.GetEnvironment((UIProviderComponentInquiry) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      UIProviderComponentInquiry cdo,
      UIProviderComponentInquiry_Request request,
      out UIProviderComponentInquiry_Result result)
    {
      result = (UIProviderComponentInquiry_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IUIProviderComponentInquiryService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new UIProviderComponentInquiryMethod(cdo, UIProviderComponentInquiryMethods.ExecuteTransaction, (UIProviderComponentInquiry_Parameters) null));
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
        UIProviderComponentInquiry_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((UIProviderComponentInquiry) cdo, (UIProviderComponentInquiry_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(UIProviderComponentInquiry cdo)
    {
      return this.ExecuteTransaction(cdo, (UIProviderComponentInquiry_Request) null, out UIProviderComponentInquiry_Result _);
    }

    public ResultStatus ExecuteTransaction(
      UIProviderComponentInquiry_Request request,
      out UIProviderComponentInquiry_Result result)
    {
      return this.ExecuteTransaction((UIProviderComponentInquiry) null, request, out result);
    }

    public ResultStatus AddDataTransaction(UIProviderComponentInquiry cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new UIProviderComponentInquiryMethod(cdo, UIProviderComponentInquiryMethods.AddDataTransaction, (UIProviderComponentInquiry_Parameters) null));
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
        return this.AddDataTransaction((UIProviderComponentInquiry) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}
