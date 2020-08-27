// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.WhereUsedConfigMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class WhereUsedConfigMaintService : NamedDataObjectMaintBase
  {
    public WhereUsedConfigMaintService(UserProfile userProfile)
    {
      this.Initialize(typeof (IWhereUsedConfigMaintService), userProfile);
    }

    public ResultStatus Delete(
      WhereUsedConfigMaint whereUsedConfigMaint,
      WhereUsedConfigMaint_Parameters parameters,
      WhereUsedConfigMaint_Request request,
      out WhereUsedConfigMaint_Result result)
    {
      result = (WhereUsedConfigMaint_Result) null;
      this.OnBeforeCall(nameof (Delete), (DCObject) whereUsedConfigMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IWhereUsedConfigMaintService) this._Channel).Delete(this._UserProfile, whereUsedConfigMaint, parameters, request, out result) : this.AddMethod((Method) new WhereUsedConfigMaintMethod(whereUsedConfigMaint, WhereUsedConfigMaintMethods.Delete, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Delete), res, (DCObject) whereUsedConfigMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Delete()
    {
      return this.Delete((WhereUsedConfigMaint) null, (WhereUsedConfigMaint_Parameters) null, (WhereUsedConfigMaint_Request) null, out WhereUsedConfigMaint_Result _);
    }

    public ResultStatus Delete(WhereUsedConfigMaint whereUsedConfigMaint)
    {
      return this.Delete(whereUsedConfigMaint, (WhereUsedConfigMaint_Parameters) null, (WhereUsedConfigMaint_Request) null, out WhereUsedConfigMaint_Result _);
    }

    public ResultStatus Delete(
      WhereUsedConfigMaint whereUsedConfigMaint,
      WhereUsedConfigMaint_Request request,
      out WhereUsedConfigMaint_Result result)
    {
      return this.Delete(whereUsedConfigMaint, (WhereUsedConfigMaint_Parameters) null, request, out result);
    }

    public ResultStatus Freeze(
      WhereUsedConfigMaint whereUsedConfigMaint,
      WhereUsedConfigMaint_Parameters parameters,
      WhereUsedConfigMaint_Request request,
      out WhereUsedConfigMaint_Result result)
    {
      result = (WhereUsedConfigMaint_Result) null;
      this.OnBeforeCall(nameof (Freeze), (DCObject) whereUsedConfigMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IWhereUsedConfigMaintService) this._Channel).Freeze(this._UserProfile, whereUsedConfigMaint, parameters, request, out result) : this.AddMethod((Method) new WhereUsedConfigMaintMethod(whereUsedConfigMaint, WhereUsedConfigMaintMethods.Freeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Freeze), res, (DCObject) whereUsedConfigMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Freeze()
    {
      return this.Freeze((WhereUsedConfigMaint) null, (WhereUsedConfigMaint_Parameters) null, (WhereUsedConfigMaint_Request) null, out WhereUsedConfigMaint_Result _);
    }

    public ResultStatus Freeze(WhereUsedConfigMaint whereUsedConfigMaint)
    {
      return this.Freeze(whereUsedConfigMaint, (WhereUsedConfigMaint_Parameters) null, (WhereUsedConfigMaint_Request) null, out WhereUsedConfigMaint_Result _);
    }

    public ResultStatus Freeze(
      WhereUsedConfigMaint whereUsedConfigMaint,
      WhereUsedConfigMaint_Request request,
      out WhereUsedConfigMaint_Result result)
    {
      return this.Freeze(whereUsedConfigMaint, (WhereUsedConfigMaint_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      WhereUsedConfigMaint whereUsedConfigMaint,
      WhereUsedConfigMaint_Parameters parameters,
      WhereUsedConfigMaint_Request request,
      out WhereUsedConfigMaint_Result result)
    {
      result = (WhereUsedConfigMaint_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) whereUsedConfigMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IWhereUsedConfigMaintService) this._Channel).GetWIPMsgs(this._UserProfile, whereUsedConfigMaint, parameters, request, out result) : this.AddMethod((Method) new WhereUsedConfigMaintMethod(whereUsedConfigMaint, WhereUsedConfigMaintMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) whereUsedConfigMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((WhereUsedConfigMaint) null, (WhereUsedConfigMaint_Parameters) null, (WhereUsedConfigMaint_Request) null, out WhereUsedConfigMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(WhereUsedConfigMaint whereUsedConfigMaint)
    {
      return this.GetWIPMsgs(whereUsedConfigMaint, (WhereUsedConfigMaint_Parameters) null, (WhereUsedConfigMaint_Request) null, out WhereUsedConfigMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(
      WhereUsedConfigMaint whereUsedConfigMaint,
      WhereUsedConfigMaint_Request request,
      out WhereUsedConfigMaint_Result result)
    {
      return this.GetWIPMsgs(whereUsedConfigMaint, (WhereUsedConfigMaint_Parameters) null, request, out result);
    }

    public ResultStatus Load(
      WhereUsedConfigMaint whereUsedConfigMaint,
      WhereUsedConfigMaint_Parameters parameters,
      WhereUsedConfigMaint_Request request,
      out WhereUsedConfigMaint_Result result)
    {
      result = (WhereUsedConfigMaint_Result) null;
      this.OnBeforeCall(nameof (Load), (DCObject) whereUsedConfigMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IWhereUsedConfigMaintService) this._Channel).Load(this._UserProfile, whereUsedConfigMaint, parameters, request, out result) : this.AddMethod((Method) new WhereUsedConfigMaintMethod(whereUsedConfigMaint, WhereUsedConfigMaintMethods.Load, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Load), res, (DCObject) whereUsedConfigMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Load()
    {
      return this.Load((WhereUsedConfigMaint) null, (WhereUsedConfigMaint_Parameters) null, (WhereUsedConfigMaint_Request) null, out WhereUsedConfigMaint_Result _);
    }

    public ResultStatus Load(WhereUsedConfigMaint whereUsedConfigMaint)
    {
      return this.Load(whereUsedConfigMaint, (WhereUsedConfigMaint_Parameters) null, (WhereUsedConfigMaint_Request) null, out WhereUsedConfigMaint_Result _);
    }

    public ResultStatus Load(
      WhereUsedConfigMaint whereUsedConfigMaint,
      WhereUsedConfigMaint_Request request,
      out WhereUsedConfigMaint_Result result)
    {
      return this.Load(whereUsedConfigMaint, (WhereUsedConfigMaint_Parameters) null, request, out result);
    }

    public ResultStatus LoadESigDetails(
      WhereUsedConfigMaint whereUsedConfigMaint,
      WhereUsedConfigMaint_LoadESigDetails_Parameters parameters,
      WhereUsedConfigMaint_Request request,
      out WhereUsedConfigMaint_Result result)
    {
      result = (WhereUsedConfigMaint_Result) null;
      this.OnBeforeCall(nameof (LoadESigDetails), (DCObject) whereUsedConfigMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IWhereUsedConfigMaintService) this._Channel).LoadESigDetails(this._UserProfile, whereUsedConfigMaint, parameters, request, out result) : this.AddMethod((Method) new WhereUsedConfigMaintMethod(whereUsedConfigMaint, WhereUsedConfigMaintMethods.LoadESigDetails, (WhereUsedConfigMaint_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadESigDetails), res, (DCObject) whereUsedConfigMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadESigDetails()
    {
      return this.LoadESigDetails((WhereUsedConfigMaint) null, (WhereUsedConfigMaint_LoadESigDetails_Parameters) null, (WhereUsedConfigMaint_Request) null, out WhereUsedConfigMaint_Result _);
    }

    public ResultStatus LoadESigDetails(WhereUsedConfigMaint whereUsedConfigMaint)
    {
      return this.LoadESigDetails(whereUsedConfigMaint, (WhereUsedConfigMaint_LoadESigDetails_Parameters) null, (WhereUsedConfigMaint_Request) null, out WhereUsedConfigMaint_Result _);
    }

    public ResultStatus LoadESigDetails(
      WhereUsedConfigMaint whereUsedConfigMaint,
      WhereUsedConfigMaint_Request request,
      out WhereUsedConfigMaint_Result result)
    {
      return this.LoadESigDetails(whereUsedConfigMaint, (WhereUsedConfigMaint_LoadESigDetails_Parameters) null, request, out result);
    }

    public ResultStatus New(
      WhereUsedConfigMaint whereUsedConfigMaint,
      WhereUsedConfigMaint_Parameters parameters,
      WhereUsedConfigMaint_Request request,
      out WhereUsedConfigMaint_Result result)
    {
      result = (WhereUsedConfigMaint_Result) null;
      this.OnBeforeCall(nameof (New), (DCObject) whereUsedConfigMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IWhereUsedConfigMaintService) this._Channel).New(this._UserProfile, whereUsedConfigMaint, parameters, request, out result) : this.AddMethod((Method) new WhereUsedConfigMaintMethod(whereUsedConfigMaint, WhereUsedConfigMaintMethods.New, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (New), res, (DCObject) whereUsedConfigMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus New()
    {
      return this.New((WhereUsedConfigMaint) null, (WhereUsedConfigMaint_Parameters) null, (WhereUsedConfigMaint_Request) null, out WhereUsedConfigMaint_Result _);
    }

    public ResultStatus New(WhereUsedConfigMaint whereUsedConfigMaint)
    {
      return this.New(whereUsedConfigMaint, (WhereUsedConfigMaint_Parameters) null, (WhereUsedConfigMaint_Request) null, out WhereUsedConfigMaint_Result _);
    }

    public ResultStatus New(
      WhereUsedConfigMaint whereUsedConfigMaint,
      WhereUsedConfigMaint_Request request,
      out WhereUsedConfigMaint_Result result)
    {
      return this.New(whereUsedConfigMaint, (WhereUsedConfigMaint_Parameters) null, request, out result);
    }

    public ResultStatus NewCopy(
      WhereUsedConfigMaint whereUsedConfigMaint,
      WhereUsedConfigMaint_Parameters parameters,
      WhereUsedConfigMaint_Request request,
      out WhereUsedConfigMaint_Result result)
    {
      result = (WhereUsedConfigMaint_Result) null;
      this.OnBeforeCall(nameof (NewCopy), (DCObject) whereUsedConfigMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IWhereUsedConfigMaintService) this._Channel).NewCopy(this._UserProfile, whereUsedConfigMaint, parameters, request, out result) : this.AddMethod((Method) new WhereUsedConfigMaintMethod(whereUsedConfigMaint, WhereUsedConfigMaintMethods.NewCopy, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (NewCopy), res, (DCObject) whereUsedConfigMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus NewCopy()
    {
      return this.NewCopy((WhereUsedConfigMaint) null, (WhereUsedConfigMaint_Parameters) null, (WhereUsedConfigMaint_Request) null, out WhereUsedConfigMaint_Result _);
    }

    public ResultStatus NewCopy(WhereUsedConfigMaint whereUsedConfigMaint)
    {
      return this.NewCopy(whereUsedConfigMaint, (WhereUsedConfigMaint_Parameters) null, (WhereUsedConfigMaint_Request) null, out WhereUsedConfigMaint_Result _);
    }

    public ResultStatus NewCopy(
      WhereUsedConfigMaint whereUsedConfigMaint,
      WhereUsedConfigMaint_Request request,
      out WhereUsedConfigMaint_Result result)
    {
      return this.NewCopy(whereUsedConfigMaint, (WhereUsedConfigMaint_Parameters) null, request, out result);
    }

    public ResultStatus SaveAs(
      WhereUsedConfigMaint whereUsedConfigMaint,
      WhereUsedConfigMaint_Parameters parameters,
      WhereUsedConfigMaint_Request request,
      out WhereUsedConfigMaint_Result result)
    {
      result = (WhereUsedConfigMaint_Result) null;
      this.OnBeforeCall(nameof (SaveAs), (DCObject) whereUsedConfigMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IWhereUsedConfigMaintService) this._Channel).SaveAs(this._UserProfile, whereUsedConfigMaint, parameters, request, out result) : this.AddMethod((Method) new WhereUsedConfigMaintMethod(whereUsedConfigMaint, WhereUsedConfigMaintMethods.SaveAs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (SaveAs), res, (DCObject) whereUsedConfigMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus SaveAs()
    {
      return this.SaveAs((WhereUsedConfigMaint) null, (WhereUsedConfigMaint_Parameters) null, (WhereUsedConfigMaint_Request) null, out WhereUsedConfigMaint_Result _);
    }

    public ResultStatus SaveAs(WhereUsedConfigMaint whereUsedConfigMaint)
    {
      return this.SaveAs(whereUsedConfigMaint, (WhereUsedConfigMaint_Parameters) null, (WhereUsedConfigMaint_Request) null, out WhereUsedConfigMaint_Result _);
    }

    public ResultStatus SaveAs(
      WhereUsedConfigMaint whereUsedConfigMaint,
      WhereUsedConfigMaint_Request request,
      out WhereUsedConfigMaint_Result result)
    {
      return this.SaveAs(whereUsedConfigMaint, (WhereUsedConfigMaint_Parameters) null, request, out result);
    }

    public ResultStatus UnFreeze(
      WhereUsedConfigMaint whereUsedConfigMaint,
      WhereUsedConfigMaint_Parameters parameters,
      WhereUsedConfigMaint_Request request,
      out WhereUsedConfigMaint_Result result)
    {
      result = (WhereUsedConfigMaint_Result) null;
      this.OnBeforeCall(nameof (UnFreeze), (DCObject) whereUsedConfigMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IWhereUsedConfigMaintService) this._Channel).UnFreeze(this._UserProfile, whereUsedConfigMaint, parameters, request, out result) : this.AddMethod((Method) new WhereUsedConfigMaintMethod(whereUsedConfigMaint, WhereUsedConfigMaintMethods.UnFreeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (UnFreeze), res, (DCObject) whereUsedConfigMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus UnFreeze()
    {
      return this.UnFreeze((WhereUsedConfigMaint) null, (WhereUsedConfigMaint_Parameters) null, (WhereUsedConfigMaint_Request) null, out WhereUsedConfigMaint_Result _);
    }

    public ResultStatus UnFreeze(WhereUsedConfigMaint whereUsedConfigMaint)
    {
      return this.UnFreeze(whereUsedConfigMaint, (WhereUsedConfigMaint_Parameters) null, (WhereUsedConfigMaint_Request) null, out WhereUsedConfigMaint_Result _);
    }

    public ResultStatus UnFreeze(
      WhereUsedConfigMaint whereUsedConfigMaint,
      WhereUsedConfigMaint_Request request,
      out WhereUsedConfigMaint_Result result)
    {
      return this.UnFreeze(whereUsedConfigMaint, (WhereUsedConfigMaint_Parameters) null, request, out result);
    }

    protected override ResultStatus OnDelete(
      DCObject whereUsedConfigMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        WhereUsedConfigMaint_Result result1;
        ResultStatus resultStatus = this.Delete((WhereUsedConfigMaint) whereUsedConfigMaint, (WhereUsedConfigMaint_Parameters) parameters, (WhereUsedConfigMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnFreeze(
      DCObject whereUsedConfigMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        WhereUsedConfigMaint_Result result1;
        ResultStatus resultStatus = this.Freeze((WhereUsedConfigMaint) whereUsedConfigMaint, (WhereUsedConfigMaint_Parameters) parameters, (WhereUsedConfigMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadESigDetails(
      DCObject whereUsedConfigMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        WhereUsedConfigMaint_Result result1;
        ResultStatus resultStatus = this.LoadESigDetails((WhereUsedConfigMaint) whereUsedConfigMaint, (WhereUsedConfigMaint_LoadESigDetails_Parameters) parameters, (WhereUsedConfigMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNew(
      DCObject whereUsedConfigMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        WhereUsedConfigMaint_Result result1;
        ResultStatus resultStatus = this.New((WhereUsedConfigMaint) whereUsedConfigMaint, (WhereUsedConfigMaint_Parameters) parameters, (WhereUsedConfigMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNewCopy(
      DCObject whereUsedConfigMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        WhereUsedConfigMaint_Result result1;
        ResultStatus resultStatus = this.NewCopy((WhereUsedConfigMaint) whereUsedConfigMaint, (WhereUsedConfigMaint_Parameters) parameters, (WhereUsedConfigMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnSaveAs(
      DCObject whereUsedConfigMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        WhereUsedConfigMaint_Result result1;
        ResultStatus resultStatus = this.SaveAs((WhereUsedConfigMaint) whereUsedConfigMaint, (WhereUsedConfigMaint_Parameters) parameters, (WhereUsedConfigMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnUnFreeze(
      DCObject whereUsedConfigMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        WhereUsedConfigMaint_Result result1;
        ResultStatus resultStatus = this.UnFreeze((WhereUsedConfigMaint) whereUsedConfigMaint, (WhereUsedConfigMaint_Parameters) parameters, (WhereUsedConfigMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoad(
      DCObject whereUsedConfigMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        WhereUsedConfigMaint_Result result1;
        ResultStatus resultStatus = this.Load((WhereUsedConfigMaint) whereUsedConfigMaint, (WhereUsedConfigMaint_Parameters) parameters, (WhereUsedConfigMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject whereUsedConfigMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        WhereUsedConfigMaint_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((WhereUsedConfigMaint) whereUsedConfigMaint, (WhereUsedConfigMaint_Parameters) parameters, (WhereUsedConfigMaint_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      WhereUsedConfigMaint_Request request,
      out WhereUsedConfigMaint_Result result)
    {
      result = (WhereUsedConfigMaint_Result) null;
      try
      {
        WhereUsedConfigMaintMethod[] methods = new WhereUsedConfigMaintMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((IWhereUsedConfigMaintService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        WhereUsedConfigMaint_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((WhereUsedConfigMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      WhereUsedConfigMaint cdo,
      WhereUsedConfigMaint_Request request,
      out WhereUsedConfigMaint_Result result)
    {
      result = (WhereUsedConfigMaint_Result) null;
      try
      {
        return ((IWhereUsedConfigMaintService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        WhereUsedConfigMaint_Result result1;
        ResultStatus environment = this.GetEnvironment((WhereUsedConfigMaint) cdo, (WhereUsedConfigMaint_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      WhereUsedConfigMaint_Request request,
      out WhereUsedConfigMaint_Result result)
    {
      return this.GetEnvironment((WhereUsedConfigMaint) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      WhereUsedConfigMaint cdo,
      WhereUsedConfigMaint_Request request,
      out WhereUsedConfigMaint_Result result)
    {
      result = (WhereUsedConfigMaint_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IWhereUsedConfigMaintService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new WhereUsedConfigMaintMethod(cdo, WhereUsedConfigMaintMethods.ExecuteTransaction, (WhereUsedConfigMaint_Parameters) null));
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
        WhereUsedConfigMaint_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((WhereUsedConfigMaint) cdo, (WhereUsedConfigMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(WhereUsedConfigMaint cdo)
    {
      return this.ExecuteTransaction(cdo, (WhereUsedConfigMaint_Request) null, out WhereUsedConfigMaint_Result _);
    }

    public ResultStatus ExecuteTransaction(
      WhereUsedConfigMaint_Request request,
      out WhereUsedConfigMaint_Result result)
    {
      return this.ExecuteTransaction((WhereUsedConfigMaint) null, request, out result);
    }

    public ResultStatus AddDataTransaction(WhereUsedConfigMaint cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new WhereUsedConfigMaintMethod(cdo, WhereUsedConfigMaintMethods.AddDataTransaction, (WhereUsedConfigMaint_Parameters) null));
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
        return this.AddDataTransaction((WhereUsedConfigMaint) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}
