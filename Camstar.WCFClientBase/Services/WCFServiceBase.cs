// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.WCFServiceBase
// Assembly: Camstar.WCFClientBase, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: E448AB03-ACEB-4B6E-82CB-FFB6A3DB1FB3
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClientBase.dll

using Camstar.WCF.ObjectStack;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  public abstract class WCFServiceBase
  {
    private static Dictionary<Type, IClientChannel> _ChannelCache = new Dictionary<Type, IClientChannel>();
    private static object _LockObject = new object();
    protected List<Method> _Methods = new List<Method>();
    protected IClientChannel _Channel;
    protected UserProfile _UserProfile;
    protected bool _IsTransactionOpened;

    public UserProfile UserProfile
    {
      get
      {
        return this._UserProfile;
      }
      set
      {
        this._UserProfile = value;
      }
    }

    public string ServiceName
    {
      get
      {
        string name = this.GetType().Name;
        return name.Remove(name.Length - 7);
      }
    }

    public void Close()
    {
      try
      {
        this._Channel.Close();
      }
      catch (Exception ex)
      {
        throw new WCFServiceException(ex);
      }
    }

    protected void Initialize(Type interfaceType, UserProfile userProfile)
    {
      try
      {
        this._UserProfile = userProfile;
        if (WCFServiceBase._ChannelCache.ContainsKey(interfaceType))
          this._Channel = WCFServiceBase._ChannelCache[interfaceType];
        lock (WCFServiceBase._LockObject)
        {
          if (this._Channel == null || this._Channel.State != CommunicationState.Opened)
          {
            ChannelFactory channelFactory = typeof (ChannelFactory<>).MakeGenericType(interfaceType).GetConstructor(new Type[1]
            {
              typeof (string)
            }).Invoke(new object[1]
            {
              (object) this.GetType().FullName
            }) as ChannelFactory;
            this._Channel = channelFactory.GetType().GetMethod("CreateChannel", Type.EmptyTypes).Invoke((object) channelFactory, (object[]) null) as IClientChannel;
            this._Channel.Open();
            WCFServiceBase._ChannelCache[interfaceType] = this._Channel;
          }
          else
            this._Channel = WCFServiceBase._ChannelCache[interfaceType];
        }
      }
      catch (Exception ex)
      {
        throw new WCFServiceException(ex.InnerException ?? ex);
      }
    }

    protected virtual ResultStatus OnThrowException(Exception e)
    {
      if (e.InnerException != null)
        e = e.InnerException;
      ResultStatus resultStatus = new ResultStatus();
      resultStatus.IsSuccess = false;
      resultStatus.ExceptionData = new ExceptionDataType();
      if (e is Win32Exception)
        resultStatus.ExceptionData.Code = (e as Win32Exception).ErrorCode;
      resultStatus.ExceptionData.ExceptionLevel = ExceptionLevel.Client;
      resultStatus.ExceptionData.Description = e.Message;
      resultStatus.ExceptionData.FailureContext = e.StackTrace;
      return resultStatus;
    }
  }
}
