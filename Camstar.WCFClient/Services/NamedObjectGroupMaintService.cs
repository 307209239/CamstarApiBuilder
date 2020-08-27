// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.NamedObjectGroupMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class NamedObjectGroupMaintService : ObjectGroupMaintBase
  {
    public NamedObjectGroupMaintService(UserProfile userProfile)
    {
      this.Initialize(typeof (INamedObjectGroupMaintService), userProfile);
    }

    public ResultStatus Delete(
      NamedObjectGroupMaint namedObjectGroupMaint,
      NamedObjectGroupMaint_Parameters parameters,
      NamedObjectGroupMaint_Request request,
      out NamedObjectGroupMaint_Result result)
    {
      result = (NamedObjectGroupMaint_Result) null;
      this.OnBeforeCall(nameof (Delete), (DCObject) namedObjectGroupMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((INamedObjectGroupMaintService) this._Channel).Delete(this._UserProfile, namedObjectGroupMaint, parameters, request, out result) : this.AddMethod((Method) new NamedObjectGroupMaintMethod(namedObjectGroupMaint, NamedObjectGroupMaintMethods.Delete, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Delete), res, (DCObject) namedObjectGroupMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Delete()
    {
      return this.Delete((NamedObjectGroupMaint) null, (NamedObjectGroupMaint_Parameters) null, (NamedObjectGroupMaint_Request) null, out NamedObjectGroupMaint_Result _);
    }

    public ResultStatus Delete(NamedObjectGroupMaint namedObjectGroupMaint)
    {
      return this.Delete(namedObjectGroupMaint, (NamedObjectGroupMaint_Parameters) null, (NamedObjectGroupMaint_Request) null, out NamedObjectGroupMaint_Result _);
    }

    public ResultStatus Delete(
      NamedObjectGroupMaint namedObjectGroupMaint,
      NamedObjectGroupMaint_Request request,
      out NamedObjectGroupMaint_Result result)
    {
      return this.Delete(namedObjectGroupMaint, (NamedObjectGroupMaint_Parameters) null, request, out result);
    }

    public ResultStatus Freeze(
      NamedObjectGroupMaint namedObjectGroupMaint,
      NamedObjectGroupMaint_Parameters parameters,
      NamedObjectGroupMaint_Request request,
      out NamedObjectGroupMaint_Result result)
    {
      result = (NamedObjectGroupMaint_Result) null;
      this.OnBeforeCall(nameof (Freeze), (DCObject) namedObjectGroupMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((INamedObjectGroupMaintService) this._Channel).Freeze(this._UserProfile, namedObjectGroupMaint, parameters, request, out result) : this.AddMethod((Method) new NamedObjectGroupMaintMethod(namedObjectGroupMaint, NamedObjectGroupMaintMethods.Freeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Freeze), res, (DCObject) namedObjectGroupMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Freeze()
    {
      return this.Freeze((NamedObjectGroupMaint) null, (NamedObjectGroupMaint_Parameters) null, (NamedObjectGroupMaint_Request) null, out NamedObjectGroupMaint_Result _);
    }

    public ResultStatus Freeze(NamedObjectGroupMaint namedObjectGroupMaint)
    {
      return this.Freeze(namedObjectGroupMaint, (NamedObjectGroupMaint_Parameters) null, (NamedObjectGroupMaint_Request) null, out NamedObjectGroupMaint_Result _);
    }

    public ResultStatus Freeze(
      NamedObjectGroupMaint namedObjectGroupMaint,
      NamedObjectGroupMaint_Request request,
      out NamedObjectGroupMaint_Result result)
    {
      return this.Freeze(namedObjectGroupMaint, (NamedObjectGroupMaint_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      NamedObjectGroupMaint namedObjectGroupMaint,
      NamedObjectGroupMaint_Parameters parameters,
      NamedObjectGroupMaint_Request request,
      out NamedObjectGroupMaint_Result result)
    {
      result = (NamedObjectGroupMaint_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) namedObjectGroupMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((INamedObjectGroupMaintService) this._Channel).GetWIPMsgs(this._UserProfile, namedObjectGroupMaint, parameters, request, out result) : this.AddMethod((Method) new NamedObjectGroupMaintMethod(namedObjectGroupMaint, NamedObjectGroupMaintMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) namedObjectGroupMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((NamedObjectGroupMaint) null, (NamedObjectGroupMaint_Parameters) null, (NamedObjectGroupMaint_Request) null, out NamedObjectGroupMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(NamedObjectGroupMaint namedObjectGroupMaint)
    {
      return this.GetWIPMsgs(namedObjectGroupMaint, (NamedObjectGroupMaint_Parameters) null, (NamedObjectGroupMaint_Request) null, out NamedObjectGroupMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(
      NamedObjectGroupMaint namedObjectGroupMaint,
      NamedObjectGroupMaint_Request request,
      out NamedObjectGroupMaint_Result result)
    {
      return this.GetWIPMsgs(namedObjectGroupMaint, (NamedObjectGroupMaint_Parameters) null, request, out result);
    }

    public ResultStatus Load(
      NamedObjectGroupMaint namedObjectGroupMaint,
      NamedObjectGroupMaint_Parameters parameters,
      NamedObjectGroupMaint_Request request,
      out NamedObjectGroupMaint_Result result)
    {
      result = (NamedObjectGroupMaint_Result) null;
      this.OnBeforeCall(nameof (Load), (DCObject) namedObjectGroupMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((INamedObjectGroupMaintService) this._Channel).Load(this._UserProfile, namedObjectGroupMaint, parameters, request, out result) : this.AddMethod((Method) new NamedObjectGroupMaintMethod(namedObjectGroupMaint, NamedObjectGroupMaintMethods.Load, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Load), res, (DCObject) namedObjectGroupMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Load()
    {
      return this.Load((NamedObjectGroupMaint) null, (NamedObjectGroupMaint_Parameters) null, (NamedObjectGroupMaint_Request) null, out NamedObjectGroupMaint_Result _);
    }

    public ResultStatus Load(NamedObjectGroupMaint namedObjectGroupMaint)
    {
      return this.Load(namedObjectGroupMaint, (NamedObjectGroupMaint_Parameters) null, (NamedObjectGroupMaint_Request) null, out NamedObjectGroupMaint_Result _);
    }

    public ResultStatus Load(
      NamedObjectGroupMaint namedObjectGroupMaint,
      NamedObjectGroupMaint_Request request,
      out NamedObjectGroupMaint_Result result)
    {
      return this.Load(namedObjectGroupMaint, (NamedObjectGroupMaint_Parameters) null, request, out result);
    }

    public ResultStatus LoadESigDetails(
      NamedObjectGroupMaint namedObjectGroupMaint,
      NamedObjectGroupMaint_LoadESigDetails_Parameters parameters,
      NamedObjectGroupMaint_Request request,
      out NamedObjectGroupMaint_Result result)
    {
      result = (NamedObjectGroupMaint_Result) null;
      this.OnBeforeCall(nameof (LoadESigDetails), (DCObject) namedObjectGroupMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((INamedObjectGroupMaintService) this._Channel).LoadESigDetails(this._UserProfile, namedObjectGroupMaint, parameters, request, out result) : this.AddMethod((Method) new NamedObjectGroupMaintMethod(namedObjectGroupMaint, NamedObjectGroupMaintMethods.LoadESigDetails, (NamedObjectGroupMaint_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadESigDetails), res, (DCObject) namedObjectGroupMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadESigDetails()
    {
      return this.LoadESigDetails((NamedObjectGroupMaint) null, (NamedObjectGroupMaint_LoadESigDetails_Parameters) null, (NamedObjectGroupMaint_Request) null, out NamedObjectGroupMaint_Result _);
    }

    public ResultStatus LoadESigDetails(NamedObjectGroupMaint namedObjectGroupMaint)
    {
      return this.LoadESigDetails(namedObjectGroupMaint, (NamedObjectGroupMaint_LoadESigDetails_Parameters) null, (NamedObjectGroupMaint_Request) null, out NamedObjectGroupMaint_Result _);
    }

    public ResultStatus LoadESigDetails(
      NamedObjectGroupMaint namedObjectGroupMaint,
      NamedObjectGroupMaint_Request request,
      out NamedObjectGroupMaint_Result result)
    {
      return this.LoadESigDetails(namedObjectGroupMaint, (NamedObjectGroupMaint_LoadESigDetails_Parameters) null, request, out result);
    }

    public ResultStatus New(
      NamedObjectGroupMaint namedObjectGroupMaint,
      NamedObjectGroupMaint_Parameters parameters,
      NamedObjectGroupMaint_Request request,
      out NamedObjectGroupMaint_Result result)
    {
      result = (NamedObjectGroupMaint_Result) null;
      this.OnBeforeCall(nameof (New), (DCObject) namedObjectGroupMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((INamedObjectGroupMaintService) this._Channel).New(this._UserProfile, namedObjectGroupMaint, parameters, request, out result) : this.AddMethod((Method) new NamedObjectGroupMaintMethod(namedObjectGroupMaint, NamedObjectGroupMaintMethods.New, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (New), res, (DCObject) namedObjectGroupMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus New()
    {
      return this.New((NamedObjectGroupMaint) null, (NamedObjectGroupMaint_Parameters) null, (NamedObjectGroupMaint_Request) null, out NamedObjectGroupMaint_Result _);
    }

    public ResultStatus New(NamedObjectGroupMaint namedObjectGroupMaint)
    {
      return this.New(namedObjectGroupMaint, (NamedObjectGroupMaint_Parameters) null, (NamedObjectGroupMaint_Request) null, out NamedObjectGroupMaint_Result _);
    }

    public ResultStatus New(
      NamedObjectGroupMaint namedObjectGroupMaint,
      NamedObjectGroupMaint_Request request,
      out NamedObjectGroupMaint_Result result)
    {
      return this.New(namedObjectGroupMaint, (NamedObjectGroupMaint_Parameters) null, request, out result);
    }

    public ResultStatus NewCopy(
      NamedObjectGroupMaint namedObjectGroupMaint,
      NamedObjectGroupMaint_Parameters parameters,
      NamedObjectGroupMaint_Request request,
      out NamedObjectGroupMaint_Result result)
    {
      result = (NamedObjectGroupMaint_Result) null;
      this.OnBeforeCall(nameof (NewCopy), (DCObject) namedObjectGroupMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((INamedObjectGroupMaintService) this._Channel).NewCopy(this._UserProfile, namedObjectGroupMaint, parameters, request, out result) : this.AddMethod((Method) new NamedObjectGroupMaintMethod(namedObjectGroupMaint, NamedObjectGroupMaintMethods.NewCopy, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (NewCopy), res, (DCObject) namedObjectGroupMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus NewCopy()
    {
      return this.NewCopy((NamedObjectGroupMaint) null, (NamedObjectGroupMaint_Parameters) null, (NamedObjectGroupMaint_Request) null, out NamedObjectGroupMaint_Result _);
    }

    public ResultStatus NewCopy(NamedObjectGroupMaint namedObjectGroupMaint)
    {
      return this.NewCopy(namedObjectGroupMaint, (NamedObjectGroupMaint_Parameters) null, (NamedObjectGroupMaint_Request) null, out NamedObjectGroupMaint_Result _);
    }

    public ResultStatus NewCopy(
      NamedObjectGroupMaint namedObjectGroupMaint,
      NamedObjectGroupMaint_Request request,
      out NamedObjectGroupMaint_Result result)
    {
      return this.NewCopy(namedObjectGroupMaint, (NamedObjectGroupMaint_Parameters) null, request, out result);
    }

    public ResultStatus SaveAs(
      NamedObjectGroupMaint namedObjectGroupMaint,
      NamedObjectGroupMaint_Parameters parameters,
      NamedObjectGroupMaint_Request request,
      out NamedObjectGroupMaint_Result result)
    {
      result = (NamedObjectGroupMaint_Result) null;
      this.OnBeforeCall(nameof (SaveAs), (DCObject) namedObjectGroupMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((INamedObjectGroupMaintService) this._Channel).SaveAs(this._UserProfile, namedObjectGroupMaint, parameters, request, out result) : this.AddMethod((Method) new NamedObjectGroupMaintMethod(namedObjectGroupMaint, NamedObjectGroupMaintMethods.SaveAs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (SaveAs), res, (DCObject) namedObjectGroupMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus SaveAs()
    {
      return this.SaveAs((NamedObjectGroupMaint) null, (NamedObjectGroupMaint_Parameters) null, (NamedObjectGroupMaint_Request) null, out NamedObjectGroupMaint_Result _);
    }

    public ResultStatus SaveAs(NamedObjectGroupMaint namedObjectGroupMaint)
    {
      return this.SaveAs(namedObjectGroupMaint, (NamedObjectGroupMaint_Parameters) null, (NamedObjectGroupMaint_Request) null, out NamedObjectGroupMaint_Result _);
    }

    public ResultStatus SaveAs(
      NamedObjectGroupMaint namedObjectGroupMaint,
      NamedObjectGroupMaint_Request request,
      out NamedObjectGroupMaint_Result result)
    {
      return this.SaveAs(namedObjectGroupMaint, (NamedObjectGroupMaint_Parameters) null, request, out result);
    }

    public ResultStatus UnFreeze(
      NamedObjectGroupMaint namedObjectGroupMaint,
      NamedObjectGroupMaint_Parameters parameters,
      NamedObjectGroupMaint_Request request,
      out NamedObjectGroupMaint_Result result)
    {
      result = (NamedObjectGroupMaint_Result) null;
      this.OnBeforeCall(nameof (UnFreeze), (DCObject) namedObjectGroupMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((INamedObjectGroupMaintService) this._Channel).UnFreeze(this._UserProfile, namedObjectGroupMaint, parameters, request, out result) : this.AddMethod((Method) new NamedObjectGroupMaintMethod(namedObjectGroupMaint, NamedObjectGroupMaintMethods.UnFreeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (UnFreeze), res, (DCObject) namedObjectGroupMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus UnFreeze()
    {
      return this.UnFreeze((NamedObjectGroupMaint) null, (NamedObjectGroupMaint_Parameters) null, (NamedObjectGroupMaint_Request) null, out NamedObjectGroupMaint_Result _);
    }

    public ResultStatus UnFreeze(NamedObjectGroupMaint namedObjectGroupMaint)
    {
      return this.UnFreeze(namedObjectGroupMaint, (NamedObjectGroupMaint_Parameters) null, (NamedObjectGroupMaint_Request) null, out NamedObjectGroupMaint_Result _);
    }

    public ResultStatus UnFreeze(
      NamedObjectGroupMaint namedObjectGroupMaint,
      NamedObjectGroupMaint_Request request,
      out NamedObjectGroupMaint_Result result)
    {
      return this.UnFreeze(namedObjectGroupMaint, (NamedObjectGroupMaint_Parameters) null, request, out result);
    }

    protected override ResultStatus OnDelete(
      DCObject namedObjectGroupMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        NamedObjectGroupMaint_Result result1;
        ResultStatus resultStatus = this.Delete((NamedObjectGroupMaint) namedObjectGroupMaint, (NamedObjectGroupMaint_Parameters) parameters, (NamedObjectGroupMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnFreeze(
      DCObject namedObjectGroupMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        NamedObjectGroupMaint_Result result1;
        ResultStatus resultStatus = this.Freeze((NamedObjectGroupMaint) namedObjectGroupMaint, (NamedObjectGroupMaint_Parameters) parameters, (NamedObjectGroupMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadESigDetails(
      DCObject namedObjectGroupMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        NamedObjectGroupMaint_Result result1;
        ResultStatus resultStatus = this.LoadESigDetails((NamedObjectGroupMaint) namedObjectGroupMaint, (NamedObjectGroupMaint_LoadESigDetails_Parameters) parameters, (NamedObjectGroupMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNew(
      DCObject namedObjectGroupMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        NamedObjectGroupMaint_Result result1;
        ResultStatus resultStatus = this.New((NamedObjectGroupMaint) namedObjectGroupMaint, (NamedObjectGroupMaint_Parameters) parameters, (NamedObjectGroupMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNewCopy(
      DCObject namedObjectGroupMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        NamedObjectGroupMaint_Result result1;
        ResultStatus resultStatus = this.NewCopy((NamedObjectGroupMaint) namedObjectGroupMaint, (NamedObjectGroupMaint_Parameters) parameters, (NamedObjectGroupMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnSaveAs(
      DCObject namedObjectGroupMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        NamedObjectGroupMaint_Result result1;
        ResultStatus resultStatus = this.SaveAs((NamedObjectGroupMaint) namedObjectGroupMaint, (NamedObjectGroupMaint_Parameters) parameters, (NamedObjectGroupMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnUnFreeze(
      DCObject namedObjectGroupMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        NamedObjectGroupMaint_Result result1;
        ResultStatus resultStatus = this.UnFreeze((NamedObjectGroupMaint) namedObjectGroupMaint, (NamedObjectGroupMaint_Parameters) parameters, (NamedObjectGroupMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoad(
      DCObject namedObjectGroupMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        NamedObjectGroupMaint_Result result1;
        ResultStatus resultStatus = this.Load((NamedObjectGroupMaint) namedObjectGroupMaint, (NamedObjectGroupMaint_Parameters) parameters, (NamedObjectGroupMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject namedObjectGroupMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        NamedObjectGroupMaint_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((NamedObjectGroupMaint) namedObjectGroupMaint, (NamedObjectGroupMaint_Parameters) parameters, (NamedObjectGroupMaint_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      NamedObjectGroupMaint_Request request,
      out NamedObjectGroupMaint_Result result)
    {
      result = (NamedObjectGroupMaint_Result) null;
      try
      {
        NamedObjectGroupMaintMethod[] methods = new NamedObjectGroupMaintMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((INamedObjectGroupMaintService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        NamedObjectGroupMaint_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((NamedObjectGroupMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      NamedObjectGroupMaint cdo,
      NamedObjectGroupMaint_Request request,
      out NamedObjectGroupMaint_Result result)
    {
      result = (NamedObjectGroupMaint_Result) null;
      try
      {
        return ((INamedObjectGroupMaintService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        NamedObjectGroupMaint_Result result1;
        ResultStatus environment = this.GetEnvironment((NamedObjectGroupMaint) cdo, (NamedObjectGroupMaint_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      NamedObjectGroupMaint_Request request,
      out NamedObjectGroupMaint_Result result)
    {
      return this.GetEnvironment((NamedObjectGroupMaint) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      NamedObjectGroupMaint cdo,
      NamedObjectGroupMaint_Request request,
      out NamedObjectGroupMaint_Result result)
    {
      result = (NamedObjectGroupMaint_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((INamedObjectGroupMaintService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new NamedObjectGroupMaintMethod(cdo, NamedObjectGroupMaintMethods.ExecuteTransaction, (NamedObjectGroupMaint_Parameters) null));
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
        NamedObjectGroupMaint_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((NamedObjectGroupMaint) cdo, (NamedObjectGroupMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(NamedObjectGroupMaint cdo)
    {
      return this.ExecuteTransaction(cdo, (NamedObjectGroupMaint_Request) null, out NamedObjectGroupMaint_Result _);
    }

    public ResultStatus ExecuteTransaction(
      NamedObjectGroupMaint_Request request,
      out NamedObjectGroupMaint_Result result)
    {
      return this.ExecuteTransaction((NamedObjectGroupMaint) null, request, out result);
    }

    public ResultStatus AddDataTransaction(NamedObjectGroupMaint cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new NamedObjectGroupMaintMethod(cdo, NamedObjectGroupMaintMethods.AddDataTransaction, (NamedObjectGroupMaint_Parameters) null));
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
        return this.AddDataTransaction((NamedObjectGroupMaint) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}
